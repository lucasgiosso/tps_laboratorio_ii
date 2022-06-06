using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Consultorio
    {
        private static int idConsultorio;
        private static string fechaConsulta;
        private static string horario;
        private static List<Paciente> listaPacientes;

        /// <summary>
        /// Constructor estático que inicializa los atributos.
        /// </summary>
        static Consultorio()
        {
            listaPacientes = new List<Paciente>();
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo id del consultorio.
        /// </summary>
        public static int IdConsultorio 
        { 
            get { return idConsultorio; } 
            set { idConsultorio = value; } 
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo fecha de la consulta.
        /// </summary>
        public static string FechaConsulta 
        { 
            get { return fechaConsulta; } 
            set { fechaConsulta = value; } 
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo horario.
        /// </summary>
        public static string Horario
        { 
            get { return horario; } 
            set { horario = value; } 
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la lista de pacientes.
        /// </summary>
        public static List<Paciente> Paciente 
        { 
            get { return listaPacientes; } 
            set { listaPacientes = value; } 
        }
        
        /// <summary>
        /// Método que obtiene los 
        /// </summary>
        /// <returns></returns>
        public static string InformacionConsultorios()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha de la consulta: {FechaConsulta}");

            return sb.ToString();
        }

        /// <summary>
        /// Método que obtiene la lista de los pacientes cargados.
        /// </summary>
        /// <returns></returns>
        public static List<Paciente> ObtenerPacientes()
        {
            return listaPacientes;
        }

        /// <summary>
        /// Método que agrega un paciente a la lista.
        /// </summary>
        /// <param name="cliente"></param>
        public static void AgregarPaciente(Paciente cliente)
        {
           listaPacientes.Add(cliente);
        }

        /// <summary>
        /// Método que elimina la posicion de la lista.
        /// </summary>
        /// <param name="idCliente"></param>
        public static void EliminarPaciente(int idCliente)
        {
            listaPacientes.RemoveAt(idCliente);
        }

        /// <summary>
        /// Método que modificar los atributos del paciente.
        /// </summary>
        /// <param name="cliente"></param>
        public static void ModificarPaciente(Paciente cliente)
        {
            listaPacientes.Add(cliente);
        }

        /// <summary>
        /// Método que muestra los turnos que se cargan en el consultorio.
        /// </summary>
        /// <returns></returns>
        public static string InformacionPacientes()
        {
            StringBuilder sb = new StringBuilder();
            DateTime fecha = DateTime.Now;

            sb.AppendLine($"Turnos de la fecha: {fecha}");

            foreach (Paciente cliente in listaPacientes)
            {
                sb.AppendLine(cliente.Informacion());
            }
            return sb.ToString();
        }
    }
}
