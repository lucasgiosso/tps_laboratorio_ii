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
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent(); 
        }

        /// <summary>
        /// Carga los datos al iniciar el formulario, en este caso completa el textbox por ser único usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            txb_Dni.Text = "Recepcion";
        }

        /// <summary>
        /// Evento del boton Inicio que al presionar valida los datos ingresados del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario(out Usuario usuario))
            {
                FormPrincipal principal = new FormPrincipal();
                principal.ShowDialog();
                this.Hide();
            }
        }

        /// <summary>
        /// Método que valida los datos que el usuario ingresa.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private bool ValidarUsuario(out Usuario usuario)
        {
            bool retorno = false;
            string pass = this.txb_Password.Text;
            
            usuario = ManejadorUsuarios.ComprobarLogin(pass);

            if (usuario is not null && !string.IsNullOrEmpty(pass))
            {
                retorno = true;
            }
            else
            {
                MessageBox.Show("Error, Por favor reingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;
        }

    }
}
