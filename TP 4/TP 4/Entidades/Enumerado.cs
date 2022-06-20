using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Enumerado para definir el tipo de consulta que va realizar el paciente.
    /// </summary>
    public enum ETipoConsulta
    {
        Ginecologia, Traumatologia, Oftalmologia, Pediatria, Nutricion
    }
    /// <summary>
    /// Enumerado para definir la obra social que utiliza el paciente.
    /// </summary>
    public enum EObraSocial
    {
        Osde, Galeno, SwissMedical
    }

}
