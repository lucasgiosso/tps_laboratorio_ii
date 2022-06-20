using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Consultorio
    {
        private static int idConsultorio;
        private static string fechaConsulta;
        private static string horario;
        private static List<string> listaHorarios;
        private static List<Paciente> listaPacientes;

        /// <summary>
        /// Constructor estático que inicializa los atributos.
        /// </summary>
        static Consultorio()
        {
            listaPacientes = new List<Paciente>();
            listaHorarios = new List<string>();       
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
        /// Propiedad de lectura y escritura de la lista de horarios.
        /// </summary>
        public static List<string> ListaHorarios
        {
            get { return listaHorarios; }
            set { listaHorarios = value; }
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
        /// Método que agrega un paciente a la lista y envia por referencia el apellido del paciente.
        /// </summary>
        /// <param name="cliente"></param>
        public static void AgregarPaciente(Paciente paciente, DelegadoMensaje metodoActualizar)
        {
            listaPacientes.Add(paciente);
            metodoActualizar(paciente.Apellido);
        }

        /// <summary>
        /// Método que elimina la posicion de la lista.
        /// </summary>
        /// <param name="idCliente"></param>
        public static void EliminarPaciente(int idPaciente)
        {
            listaPacientes.RemoveAt(idPaciente);
            
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

        /// <summary>
        /// Agregar los horarios a la lista de horarios.
        /// </summary>
        public static void CargarHorarios()
        {
            listaHorarios.Add("8 - 9 hs");
            listaHorarios.Add("9 - 10 hs");
            listaHorarios.Add("10 - 11 hs");
            listaHorarios.Add("11 - 12 hs");
            listaHorarios.Add("12 - 13 hs");
            listaHorarios.Add("13 - 14 hs");
            listaHorarios.Add("14 - 15 hs");
            listaHorarios.Add("15 - 16 hs");
            listaHorarios.Add("16 - 17 hs");
            listaHorarios.Add("17 - 18 hs");
        }
    }
 }