using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Json<T> : Extender, IManejadorArchivos<T>
        where T : class
    {
        string carpeta;

        /// <summary>
        /// Propiedad de Extension del tipo archivo
        /// </summary>
        protected override string Extension
        {
            get
            {
                return ".json";
            }
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Json()
        {
            carpeta = string.Format("{0}", AppDomain.CurrentDomain.BaseDirectory, @"\SerializacionJson");
        }

        /// <summary>
        /// Guarda la información que se le pasa por parametro en un archivo.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        /// <exception cref="ExcepcionArchivos"></exception>
        public bool Guardar(string archivo, T info)
        {
            try
            {
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                archivo = carpeta + archivo;
                File.WriteAllText(archivo, JsonSerializer.Serialize(info));
                return true;

            }
            catch (Exception ex)
            {
                throw new ExcepcionArchivos($"Error al guardar el archivo(Json): {archivo}", ex);
            }
        }

        /// <summary>
        /// Lee la información de un archivo.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        /// <exception cref="ExcepcionArchivos"></exception>
        public bool Leer(string archivo, out T info)
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
                    string json = sr.ReadToEnd();
                    info = JsonSerializer.Deserialize<T>(json);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw new ExcepcionArchivos($"Error al leer el archivo(Json): {archivo}", ex);
            }

        }
    }
}
