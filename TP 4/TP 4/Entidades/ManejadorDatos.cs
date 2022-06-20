using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorDatos
    {
        /// <summary>
        /// Metodo que simula la carga de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static async Task<string> LevantarDatos()
        {
            string informacion = await Task.Run(() => { Thread.Sleep(3000); return "Verificada"; });

            return informacion;
        }
    }
}
