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

namespace Formularios
{
    public partial class FormLista : Form
    {
        private string archivo = @"./listaPacientes.xml";
        private string archivoJson = @"./listaClientes.json";
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
        private void FormLista_Load(object sender, EventArgs e)
        {
            List<Paciente> listaClientes = Consultorio.ObtenerPacientes();
                        
            if (listaClientes.Count > 0)
            {
                this.dgv_Lista.DataSource = new BindingList<Paciente>(listaClientes);
            }
        }

        /// <summary>
        /// Método que importa los datos de un archivo xml.
        /// </summary>
        private void ImportarDatos()
        {
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
                        this.dgv_Lista.DataSource = new BindingList<Paciente>(listaPacientesInicial);
                        MessageBox.Show("Cargado correctamente en Xml", "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        json.Leer(archivoJson, out listaPacientesInicial);
                        
                        Consultorio.Paciente = listaPacientesInicial;
                        this.dgv_Lista.DataSource = new BindingList<Paciente>(listaPacientesInicial);
                        MessageBox.Show("Cargado correctamente en Json", "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                    }
                }
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int aux = dgv_Lista.CurrentRow.Index;
                    Consultorio.EliminarPaciente(aux);
                    this.dgv_Lista.DataSource = null;
                    this.dgv_Lista.DataSource = Consultorio.ObtenerPacientes();
                }
            }
            else
            {
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
        /// Evento que sirve para marcar el foco de la selección.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Lista_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                FormModificar fr = new FormModificar(this);
                fr.ShowInTaskbar = false;
                fr.ShowDialog();
            }

        }

        /// <summary>
        /// Evento del boton click que al presionar 2 clicks te da la opcion de modificar los datos del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_Lista.CurrentRow is not null)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea modificar el turno?", "Modificación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    FormModificar fr = new FormModificar(this);

                    fr.txb_NombreModificar.Text = this.dgv_Lista.CurrentRow.Cells[0].Value.ToString();
                    fr.txb_ApellidoModificar.Text = this.dgv_Lista.CurrentRow.Cells[1].Value.ToString();
                    fr.txb_DniModificar.Text = this.dgv_Lista.CurrentRow.Cells[2].Value.ToString();
                    fr.txb_MailModificar.Text = this.dgv_Lista.CurrentRow.Cells[3].Value.ToString();
                    fr.txb_TelefonoModificar.Text = this.dgv_Lista.CurrentRow.Cells[4].Value.ToString();
                    fr.dtp_AgendaModificar.Text = this.dgv_Lista.CurrentRow.Cells[5].Value.ToString();
                    fr.cmb_HorarioModificar.Text = this.dgv_Lista.CurrentRow.Cells[6].Value.ToString();
                    fr.cmb_ObraSocialListaModificar.Text = this.dgv_Lista.CurrentRow.Cells[7].Value.ToString();
                    fr.cmb_TipoConsultaModificar.Text = this.dgv_Lista.CurrentRow.Cells[8].Value.ToString();
                    fr.ShowInTaskbar = false;
                    
                    fr.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("No posee ningún turno cargado. Debe tener algún turno cargado para poder modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
