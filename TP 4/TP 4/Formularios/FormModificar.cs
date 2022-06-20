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

//Los combos deberian de no permitir escribir a mano, deberian de dejar solo seleccionar.
///(resuelto linea 38)

namespace Formularios
{
    public partial class FormModificar : Form
    {
        private Paciente paciente;
        
        public FormModificar(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
        }

        /// <summary>
        /// Carga los datos del formulario al iniciarse, en este caso inicializa los datos de los combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModificar_Load(object sender, EventArgs e)
        {
            cmb_ObraSocialListaModificar.DataSource = Enum.GetValues(typeof(EObraSocial));
            cmb_TipoConsultaModificar.DataSource = Enum.GetValues(typeof(ETipoConsulta));
            cmb_HorarioModificar.DataSource = Consultorio.ListaHorarios;

            InfoCargada();

        }

        /// <summary>
        /// Método que permite modificar los campos del datagrid.
        /// </summary>
        private void ModificarTurnos()
        {
            string nombre = txb_NombreModificar.Text;
            string apellido = txb_ApellidoModificar.Text;
            string dni = txb_DniModificar.Text;
            string mail = txb_MailModificar.Text;
            string telefono = txb_TelefonoModificar.Text;
            string fecha = dtp_AgendaModificar.Text;
            string hora = cmb_HorarioModificar.Text;
            string obraSocial = cmb_ObraSocialListaModificar.Text;
            string tipoConsulta = cmb_TipoConsultaModificar.Text;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido)
                && !string.IsNullOrEmpty(dni) && !string.IsNullOrEmpty(mail)
                && !string.IsNullOrEmpty(telefono) && !string.IsNullOrEmpty(fecha)
                && !string.IsNullOrEmpty(obraSocial) && !string.IsNullOrEmpty(hora) && !string.IsNullOrEmpty(tipoConsulta) 
                )
            {
                paciente.Nombre = txb_NombreModificar.Text;
                paciente.Apellido = txb_ApellidoModificar.Text;
                paciente.Dni = txb_DniModificar.Text;
                paciente.Mail = txb_MailModificar.Text;
                paciente.Telefono = txb_TelefonoModificar.Text;
                paciente.FechaConsulta = dtp_AgendaModificar.Text;
                paciente.Horario = cmb_HorarioModificar.Text;
                paciente.ObraSocial = (EObraSocial)cmb_ObraSocialListaModificar.SelectedValue;
                paciente.TipoConsulta = (ETipoConsulta)cmb_TipoConsultaModificar.SelectedValue;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error, por favor ingrese los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        /// <summary>
        /// Evento del boton click que modifica la información del turno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            ModificarTurnos();
        }

        /// <summary>
        /// Método que obtiene la información cargada.
        /// </summary>
        private void InfoCargada()
        {
            txb_NombreModificar.Text = paciente.Nombre;
            txb_ApellidoModificar.Text = paciente.Apellido;
            txb_DniModificar.Text = paciente.Dni;
            txb_MailModificar.Text = paciente.Mail;
            txb_TelefonoModificar.Text = paciente.Telefono;
            dtp_AgendaModificar.Text = paciente.FechaConsulta;
            cmb_HorarioModificar.SelectedItem = paciente.Horario;
            cmb_ObraSocialListaModificar.SelectedItem = paciente.ObraSocial;
            cmb_TipoConsultaModificar.SelectedItem = paciente.TipoConsulta;
        }
    }
}
