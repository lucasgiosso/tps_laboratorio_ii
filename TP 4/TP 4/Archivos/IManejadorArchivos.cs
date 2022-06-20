using System;

namespace Archivos
{
    public interface IManejadorArchivos<T>
    {
        /// <summary>
        /// Guarda la información que se le pasa por parametro en un archivo.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        bool Guardar(string archivo, T info);

        /// <summary>
        /// Lee la información del archivo guardado.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        bool Leer(string archivo, out T info);
    }
    
}
