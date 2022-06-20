using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.IO;
using System.Threading;

//Correción Errores

//Por ej, si cargo un paciente y luego importo la lista de pacientes sin haber serializado antes, pierdo lo que tenia en memoria en la lista.
//Esa lista deberia de hacerse un addrange para no perder lo que ya estaba cargado, en lugar de pisar la lista con lo que leo del file.
///(resuelto linea 99 y 108)

//El error de datagrid que esta capturado por trycatch, no debria de mostrarte literal en pantalla, deberia de
//mostrar un error más userfriendly, o bien no mostrar nada en ese caso, porque es detalle de .net.
///(resuelto linea 117)


namespace Formularios
{
    public partial class FormLista : Form
    {
        public event DelegadoDesactivarBoton desactivar;
        private string archivo = @"./listaPacientes.xml";
        private string archivoJson = @"./listaPacientes.json";
        private Xml<List<Paciente>> xml;
        private Json<List<Paciente>> json;
        private List<Paciente> listaPacientesInicial;
        private Text txtListaPacientes;

        public FormLista()
        {
            InitializeComponent();
            xml = new Xml<List<Paciente>>();
            json = new Json<List<Paciente>>();
            txtListaPacientes = new Text();
            listaPacientesInicial = new List<Paciente>();
            desactivar += DesactivarBoton;
        }

        /// <summary>
        /// Evento del boton click que realiza la apertura del formulario anterior(menu principal).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
            this.Hide();
            
        }

        /// <summary>
        /// Carga los datos al iniciar el formulario, en este caso realiza la carga de los turnos en el caso de que existiera alguno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void FormLista_Load(object sender, EventArgs e)
        {            
            btn_Importar.Visible = false;
            btn_Exportar.Visible = false;
            this.lbl_InfoCarga.Text = await ManejadorDatos.LevantarDatos();
            ActualizarDatos();
            
        }

        /// <summary>
        /// Método que importa los datos de un archivo xml.
        /// </summary>
        private void ImportarDatos()
        {
            List<Paciente> listaClientes = Consultorio.ObtenerPacientes();

            try
            {
                string rutaDirectorio = string.Empty;

                OpenFileDialog ofd = new OpenFileDialog();
                
                ofd.InitialDirectory = Application.StartupPath;
                ofd.Filter = "Xml File (*.xml)|*.xml|Json File (*.json)|*.json";
                ofd.ShowDialog();

                if (File.Exists(ofd.FileName))
                {
                    if (ofd.FilterIndex == 1)
                    {
                        xml.Leer(archivo, out listaPacientesInicial);
                        
                        Consultorio.Paciente = listaPacientesInicial;
                        listaPacientesInicial.AddRange(listaClientes);
                        this.dgv_Lista.DataSource = new BindingList<Paciente>(listaPacientesInicial);
                        MessageBox.Show("Cargado correctamente en Xml", "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        json.Leer(archivoJson, out listaPacientesInicial);
                        
                        Consultorio.Paciente = listaPacientesInicial;
                        listaPacientesInicial.AddRange(listaClientes);
                        this.dgv_Lista.DataSource = new BindingList<Paciente>(listaPacientesInicial);
                        MessageBox.Show("Cargado correctamente en Json", "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al leer el archivo. Por favor, verificar.", "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento del boton click que elimina la posicion del turno del paciente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Lista.CurrentRow is not null)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea cancelar el turno?", "Eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    //Actualización de dgv TP3
                    //int aux1 = dgv_Lista.CurrentRow.Index;
                    //Consultorio.EliminarPaciente(aux1);
                    //this.dgv_Lista.DataSource = null;
                    //this.dgv_Lista.DataSource = Consultorio.ObtenerPacientes();

                    //Actualización de dgv TP4
                    int aux2 = (int)dgv_Lista.CurrentRow.Cells[0].Value;
                    List<Paciente> listaClientes = Consultorio.ObtenerPacientes();

                    DAO.EliminarPaciente(aux2);
                    this.dgv_Lista.DataSource = null;
                    DAO.Leer(out listaClientes);

                    if (listaClientes.Count > 0)
                    {
                        this.dgv_Lista.DataSource = new BindingList<Paciente>(listaClientes);
                    }
                }
            }
            else
            {
                desactivar.Invoke();
                MessageBox.Show("No posee ningún turno cargado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento del boton click que exporta la información de turnos en archivo txt y xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            List<Paciente> listaPacientes = Consultorio.ObtenerPacientes();

            if (listaPacientes.Count < 1)
            {
                MessageBox.Show("Error. Por favor, cargue turnos para poder exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                xml.Guardar(archivo, listaPacientes);
                json.Guardar(archivoJson, listaPacientes);
                txtListaPacientes.Guardar("txtPacientes.txt",Consultorio.InformacionPacientes());
                
                MessageBox.Show("Exportando... Se exporto el archivo.", "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento del boton click que importa la información de los turnos cargados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Importar_Click(object sender, EventArgs e)
        {
            ImportarDatos();
        }

        /// <summary>
        /// Evento del boton click que al presionar 2 clicks te da la opcion de modificar los datos del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Paciente pacienteNuevo;
            List<Paciente> listaClientes = Consultorio.ObtenerPacientes();

            if (this.dgv_Lista.CurrentRow is not null)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea modificar el turno?", "Modificación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    pacienteNuevo = this.dgv_Lista.CurrentRow.DataBoundItem as Paciente;

                    FormModificar fr = new FormModificar(pacienteNuevo);

                    fr.ShowInTaskbar = false;

                    if (fr.ShowDialog() == DialogResult.OK)
                    {
                        this.dgv_Lista.DataSource = null;
                        
                        DAO.ModificarPaciente(pacienteNuevo);
                        DAO.Leer(out listaClientes);

                        if (listaClientes.Count > 0)
                        {
                            this.dgv_Lista.DataSource = new BindingList<Paciente>(listaClientes);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("No posee ningún turno cargado. Debe tener algún turno cargado para poder modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Método que actualiza los datos del datagrid.
        /// </summary>
        private async void ActualizarDatos()
        {
            List<Paciente> listaClientes = Consultorio.ObtenerPacientes();

            DAO.Leer(out listaClientes);

            if (listaClientes.Count > 0)
            {
                this.dgv_Lista.DataSource = new BindingList<Paciente>(listaClientes);
                
            }
            else
            {
                desactivar.Invoke();
                MessageBox.Show("No hay datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Método que deshabilita el boton de eliminar.
        /// </summary>
        private void DesactivarBoton()
        {
            btn_Eliminar.Enabled = false;
        }

        
    }
}
