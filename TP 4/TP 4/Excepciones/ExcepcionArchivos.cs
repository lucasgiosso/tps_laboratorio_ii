using System;

namespace Excepciones
{
    public class ExcepcionArchivos : Exception
    {
        /// <summary>
        /// Creación de la excepción con un mensaje.
        /// </summary>
        /// <param name="message"></param>
        public ExcepcionArchivos(string message) : this(message, null) 
        {

        }

        /// <summary>
        /// Creación de la excepción con un mensaje y su innerExcepcion.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ExcepcionArchivos(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
