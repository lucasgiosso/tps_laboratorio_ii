using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ManejadorUsuarios
    {
        private static List<Usuario> usuarios;

        /// <summary>
        /// Propiedad de lectura y escritura de la lista de usuarios.
        /// </summary>
        public static List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

        /// <summary>
        /// Constructor estático que inicializa a los usuarios.
        /// </summary>
        static ManejadorUsuarios()
        {
            InstanciarUsuarios();
        }

        /// <summary>
        /// Método que inicializa y agrega el usuario que va ingresar al sistema.
        /// </summary>
        private static void InstanciarUsuarios()
        {
            usuarios = new List<Usuario>();
            usuarios.Add(new Usuario("Recepcion","asalud123"));
        }

        /// <summary>
        /// Método que valida que los datos ingresados son los correctos.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Usuario ComprobarLogin(string password)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.CheckearPass(password))
                {
                    return usuario;
                }
            }
            return null;
        }


    }
}
