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
using System.Text.RegularExpressions;
using System.Threading;

namespace Formularios
{
    public partial class FormRegistro : Form
    {
        List<Paciente> listapacientes;
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FormRegistro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos del formulario al iniciarse, en este caso inicializa los datos de los combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRegistro_Load(object sender, EventArgs e)
        {

            cmb_ObraSocialLista.Items.Add(EObraSocial.Osde);
            cmb_ObraSocialLista.Items.Add(EObraSocial.Galeno);
            cmb_ObraSocialLista.Items.Add(EObraSocial.SwissMedical);

            cmb_Horario.Items.Add("8 - 9 hs");
            cmb_Horario.Items.Add("9 - 10 hs");
            cmb_Horario.Items.Add("10 - 11 hs");
            cmb_Horario.Items.Add("11 - 12 hs");
            cmb_Horario.Items.Add("12 - 13 hs");
            cmb_Horario.Items.Add("13 - 14 hs");
            cmb_Horario.Items.Add("14 - 15 hs");
            cmb_Horario.Items.Add("15 - 16 hs");
            cmb_Horario.Items.Add("16 - 17 hs");
            cmb_Horario.Items.Add("17 - 18 hs");

            cmb_TipoConsulta.Items.Add(ETipoConsulta.Ginecologia);
            cmb_TipoConsulta.Items.Add(ETipoConsulta.Traumatologia);
            cmb_TipoConsulta.Items.Add(ETipoConsulta.Oftalmologia);
            cmb_TipoConsulta.Items.Add(ETipoConsulta.Pediatria);
            cmb_TipoConsulta.Items.Add(ETipoConsulta.Nutricion);

            lbl_Info.Visible = false; 

        }

        /// <summary>
        /// Evento Keypress que al presionar un boton valida que solo se ingresen letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo letras. ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento Keypress que al presionar un boton valida que solo se ingresen letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo letras. ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento Keypress que al presionar un boton valida que solo se ingresen números.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo números sin .(puntos). ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento Keypress que al presionar un boton valida que solo se ingresen números.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números. ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento del boton que registra los turnos de los pacientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ingreso_Click(object sender, EventArgs e)
        {
            RegistroTurnos();
        }

        /// <summary>
        /// Método que guarda la informacion cargada por el usuario.
        /// </summary>
        private void RegistroTurnos()
        {
            int idPaciente = 0;
            string nombre = txb_nombre.Text;
            string apellido = txb_apellido.Text;
            string dni = txb_dni.Text;
            string telefono = txb_telefono.Text;
            string mail = txb_mail.Text;
            string fecha = dtp_agenda.Text;
            string hora = cmb_Horario.Text;
            string obraSocial = cmb_ObraSocialLista.Text;
            string tipoConsulta = cmb_TipoConsulta.Text;
            List<Paciente> listaPacientes = Consultorio.ObtenerPacientes();
            Paciente paciente;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido)
                && !string.IsNullOrEmpty(dni) && !string.IsNullOrEmpty(mail)
                && !string.IsNullOrEmpty(telefono) && !string.IsNullOrEmpty(fecha)
                && !string.IsNullOrEmpty(obraSocial) && !string.IsNullOrEmpty(hora) && !string.IsNullOrEmpty(obraSocial))
            {
                if (dni.Length == 8)
                {
                    if (mail.Contains("@"))
                    {
                        paciente = new Paciente(idPaciente, nombre, apellido, dni, mail, telefono, fecha, hora, (EObraSocial)ObtenerObraSocial(obraSocial), (ETipoConsulta)ObtenerTipoConsulta(tipoConsulta));
                        Consultorio.AgregarPaciente(paciente, PasarApell);

                        DAO.InsertarPacientes(paciente);

                        MessageBox.Show($"Se le enviara un mail al paciente a: {mail} ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);                   

                        lbl_Info.Visible = true;

                        DialogResult respuesta = MessageBox.Show("¿Desea cargar otro turno?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            FormRegistro frm = new FormRegistro();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            FormPrincipal frmPrincipal = new FormPrincipal();
                            frmPrincipal.ShowDialog();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error en la casilla de mail. Por favor, revise el dato ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("DNI Incorrecto, debe contener 8 digitos.", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Error, por favor ingrese los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que obtiene los valores en formato string de las obras sociales.
        /// </summary>
        /// <param name="obraSocial"></param>
        /// <returns></returns>
        private int ObtenerObraSocial(string obraSocial)
        {
            int nRet = -1;

            switch (obraSocial)
            {
                case "Osde":
                    return 0;
                    
                case "Galeno":
                    return 1;
                    
                case "SwissMedical":
                    return 2;
                    
                default:
                    break;
            }
            return nRet;
        }

        /// <summary>
        /// Método que obtiene los valores en formato string de tipos de consultas.
        /// </summary>
        /// <param name="tipoConsulta"></param>
        /// <returns></returns>
        private int ObtenerTipoConsulta(string tipoConsulta)
        {
            int nRet = -1;

            switch (tipoConsulta)
            {
                case "Ginecologia":
                    return 0;
                    
                case "Traumatologia":
                    return 1;
                    
                case "Oftalmologia":
                    return 2;
                    
                case "Pediatria":
                    return 3;
                   
                case "Nutricion":
                    return 4;
                    
                default:
                    break;
            }
            return nRet;
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
        /// Evento del boton click que llama al método Borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        /// <summary>
        /// Método que presetea los valores del combo box y el rich textbox.
        /// </summary>
        private void Borrar()
        {
            this.txb_nombre.Text = string.Empty;
            this.txb_apellido.Text = string.Empty;
            this.txb_dni.Text = string.Empty;
            this.txb_telefono.Text = string.Empty;
            this.txb_mail.Text = string.Empty;
            this.cmb_Horario.SelectedIndex = -1;
            this.cmb_ObraSocialLista.SelectedIndex = -1;
            this.cmb_TipoConsulta.SelectedIndex = -1;
            this.dtp_agenda.Text = string.Empty;
        }

        /// <summary>
        /// Método que devuelve la informacion con el apellido del paciente.
        /// </summary>
        /// <param name="dato"></param>
        private void PasarApell(string dato)
        {
            lbl_Info.Text = $"El turno del paciente {dato} fue agregado.";
        }
    }
}
