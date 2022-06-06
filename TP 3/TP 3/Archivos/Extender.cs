using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public abstract class Extender
    {
        protected abstract string Extension { get; }

        public bool ValidarExtension(string extension)
        {
            if (Path.GetExtension(extension) != Extension)
            {
                throw new ExcepcionArchivos($"El archivo no tiene la extension {Extension}");
            }
            return true;
        }
    }
}
