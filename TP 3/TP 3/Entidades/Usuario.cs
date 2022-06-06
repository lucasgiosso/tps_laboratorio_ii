using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombre;
        private string password;

        /// <summary>
        /// Propiedad de escritura del atributo password.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
        }
        /// <summary>
        /// Propiedad de escritura del atributo password.
        /// </summary>
        public string Password
        {
            set { password = value; }
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Usuario()
        {

        }

        /// <summary>
        /// Constructor público que inicializa el estado de todos los atributos.
        /// </summary>
        /// <param name="password"></param>
        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        /// <summary>
        /// Método que valida si password es la correcta.
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool CheckearPass(string pass)
        {
            return (!string.IsNullOrEmpty(pass) && pass.Trim() == pass.Trim() && pass == "asalud123");
        }
    }
}
