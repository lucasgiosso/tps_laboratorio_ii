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

namespace Formularios
{
    public partial class FormModificar : Form
    {
        private FormLista formLista;
        public FormModificar(FormLista formLista)
        {
            InitializeComponent();
            this.formLista = formLista;
        }

        /// <summary>
        /// Carga los datos del formulario al iniciarse, en este caso inicializa los datos de los combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModificar_Load(object sender, EventArgs e)
        {
            cmb_ObraSocialListaModificar.Items.Add(EObraSocial.Osde);
            cmb_ObraSocialListaModificar.Items.Add(EObraSocial.Galeno);
            cmb_ObraSocialListaModificar.Items.Add(EObraSocial.SwissMedical);

            cmb_HorarioModificar.Items.Add("8 - 9 hs");
            cmb_HorarioModificar.Items.Add("9 - 10 hs");
            cmb_HorarioModificar.Items.Add("10 - 11 hs");
            cmb_HorarioModificar.Items.Add("11 - 12 hs");
            cmb_HorarioModificar.Items.Add("12 - 13 hs");
            cmb_HorarioModificar.Items.Add("13 - 14 hs");
            cmb_HorarioModificar.Items.Add("14 - 15 hs");
            cmb_HorarioModificar.Items.Add("15 - 16 hs");
            cmb_HorarioModificar.Items.Add("16 - 17 hs");
            cmb_HorarioModificar.Items.Add("17 - 18 hs");

            cmb_TipoConsultaModificar.Items.Add(ETipoConsulta.Ginecologia);
            cmb_TipoConsultaModificar.Items.Add(ETipoConsulta.Traumatologia);
            cmb_TipoConsultaModificar.Items.Add(ETipoConsulta.Oftalmologia);
            cmb_TipoConsultaModificar.Items.Add(ETipoConsulta.Pediatria);
            cmb_TipoConsultaModificar.Items.Add(ETipoConsulta.Nutricion);
        }

        /// <summary>
        /// Método que permite modificar los campos del datagrid.
        /// </summary>
        private void ModificarTurnos()
        {
            string nombre = txb_NombreModificar.Text;
            string apellido = txb_ApellidoModificar.Text;
            string dni = txb_DniModificar.Text;
            string telefono = txb_TelefonoModificar.Text;
            string mail = txb_MailModificar.Text;
            string fecha = dtp_AgendaModificar.Text;
            string hora = cmb_HorarioModificar.Text;
            string obraSocial = cmb_ObraSocialListaModificar.Text;
            string tipoConsulta = cmb_TipoConsultaModificar.Text;

            formLista.dgv_Lista.CurrentRow.Cells[0].Value = txb_NombreModificar.Text;
            formLista.dgv_Lista.CurrentRow.Cells[1].Value = txb_ApellidoModificar.Text;
            formLista.dgv_Lista.CurrentRow.Cells[2].Value = txb_DniModificar.Text;
            formLista.dgv_Lista.CurrentRow.Cells[3].Value = txb_MailModificar.Text;
            formLista.dgv_Lista.CurrentRow.Cells[4].Value = txb_TelefonoModificar.Text;
            formLista.dgv_Lista.CurrentRow.Cells[5].Value = dtp_AgendaModificar.Text;
            formLista.dgv_Lista.CurrentRow.Cells[6].Value = cmb_HorarioModificar.Text;
            formLista.dgv_Lista.CurrentRow.Cells[7].Value = cmb_ObraSocialListaModificar.Text;
            formLista.dgv_Lista.CurrentRow.Cells[8].Value = cmb_TipoConsultaModificar.Text;

            this.Close();
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

    }
}
