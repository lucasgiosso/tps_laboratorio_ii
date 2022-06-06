using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Text : Extender, IManejadorArchivos<string>
    {
        string carpeta;

        /// <summary>
        /// Propiedad de Extension del tipo archivo
        /// </summary>
        protected override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Text()
        {
            carpeta = string.Format("{0}",AppDomain.CurrentDomain.BaseDirectory, "\\LogsTxt");
        }

        /// <summary>
        /// Guarda la información que se le pasa por parametro en un archivo.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Guardar(string archivo, string info)
        {
            try
            {
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                
                archivo = carpeta + archivo;

                using (StreamWriter sw = File.AppendText($"{archivo}"))
                {
                    sw.WriteLine(info);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new ExcepcionArchivos($"Error al guardar el archivo(txt): {archivo}",ex);
            } 
        }

        /// <summary>
        /// Lee la información de un archivo.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Leer(string archivo, out string info)
        {
            try
            {
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                ValidarExtension(archivo);
                archivo = carpeta + archivo;

                using (StreamReader sr = new StreamReader(archivo))
                {
                    info = sr.ReadToEnd();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new ExcepcionArchivos($"Error al leer el archivo(txt): {archivo}");
            }

        }
    }
}
