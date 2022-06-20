using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Delegado que muestra el apellido del paciente que se agrego el turno.
    /// </summary>
    /// <param name="mensaje"></param>
    public delegate void DelegadoMensaje(string mensaje);

    /// <summary>
    /// Delegado que va a desactivar el boton de eliminar
    /// </summary>
    public delegate void DelegadoDesactivarBoton();


}
