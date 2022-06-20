using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    
    public class Paciente
    {
        private int idPaciente; 
        private string nombre;
        private string apellido;
        private string dni;
        private string mail;
        private string telefono;
        private string fechaConsulta;
        private string horario;
        private EObraSocial obraSocial;
        private ETipoConsulta tipoConsulta;
        
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Paciente()
        {

        }

        public Paciente(int idPaciente) : this()
        {

        }

        /// <summary>
        /// Constructor que inicializa los atributos de la clase.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="mail"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaConsulta"></param>
        /// <param name="horario"></param>
        /// <param name="obraSocial"></param>
        /// <param name="tipoConsulta"></param>
        public Paciente(int idPaciente,string nombre, string apellido, string dni, string mail, string telefono, string fechaConsulta, string horario, EObraSocial obraSocial, ETipoConsulta tipoConsulta)
        {
            this.IdPaciente = idPaciente;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Mail = mail;
            this.Telefono = telefono;
            this.FechaConsulta = fechaConsulta;
            this.Horario = horario;
            this.ObraSocial = obraSocial;
            this.TipoConsulta = tipoConsulta;
            
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo id Paciente.
        /// </summary>
        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo nombre.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo apellido.
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo dni.
        /// </summary>
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo mail.
        /// </summary>
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo telefono.
        /// </summary>
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo fecha de la consulta.
        /// </summary>
        public string FechaConsulta
        {
            get { return fechaConsulta; }
            set { fechaConsulta = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo horario.
        /// </summary>
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del enumerado obra social.
        /// </summary>
        public EObraSocial ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del enumerado tipo de consulta.
        /// </summary>
        public ETipoConsulta TipoConsulta
        {
            get { return tipoConsulta; }
            set { tipoConsulta = value; }
        }

        /// <summary>
        /// Método que muestra la informacion del paciente.
        /// </summary>
        /// <returns></returns>
        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-------------------------------------------\n");
            sb.AppendFormat(String.Format("Nombre: {0}\n", this.Nombre));
            sb.AppendFormat(String.Format("Apellido: {0}\n", this.Apellido));
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Mail: {this.Mail}");
            sb.AppendLine($"Telefono: {this.Telefono}");
            sb.AppendLine($"Fecha de la Consulta: {this.FechaConsulta}");
            sb.AppendLine($"Horario: {this.Horario}");
            sb.AppendLine($"Obra Social: {this.ObraSocial}");
            sb.AppendLine($"Consulta con: {this.TipoConsulta}");

            return sb.ToString();
        }
    }
}
