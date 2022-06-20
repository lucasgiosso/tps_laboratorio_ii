using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : Extender, IManejadorArchivos<T>
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
                return ".xml";
            }
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Xml()
        {
            carpeta = string.Format("{0}", AppDomain.CurrentDomain.BaseDirectory, @"\SerializacionXml");
        }

        /// <summary>
        /// Guarda la información que se le pasa por parametro en un archivo.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Guardar(string archivo, T info)
        {
            try
            {
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                archivo = carpeta + archivo;

                using (XmlTextWriter w = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(w, info);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new ExcepcionArchivos($"Error al guardar el archivo(Xml): {archivo}", ex);
            }
        }

        /// <summary>
        /// Lee la información de un archivo.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

                using (XmlTextReader r = new XmlTextReader(archivo))
                {
                    XmlSerializer sr = new XmlSerializer(typeof(T));
                    info = (T)sr.Deserialize(r);
                    return true;
                }
            }
            catch (Exception exe)
            {

                throw new ExcepcionArchivos($"Error al leer el archivo(Xml): {archivo}",exe);
            }
        }
    }
}
