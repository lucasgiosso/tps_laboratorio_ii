using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Excepciones;
using Entidades;

namespace Archivos
{
    public static class DAO
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString = @"Server = .; Database = dbConsultorio ; Trusted_Connection = true ;";

        static DAO()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

        /// <summary>
        /// Método que inserta turnos en la base de datos.
        /// </summary>
        /// <param name="pacientes"></param>
        /// <returns></returns>
        /// <exception cref="ExcepcionArchivos"></exception>
        public static bool InsertarPacientes(Paciente pacientes)
        {
            try
            {
                command.CommandText = "INSERT INTO Pacientes VALUES (@Nombre, @Apellido, " +
                    "@Dni, @Mail, @Telefono, @Fecha_Consulta, @Horario, @Obra_Social, @Tipo_Consulta)";
                connection.Open();

                QueryPacientes(pacientes);
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                return true;
            }
            catch (Exception ex)
            {
                throw new ExcepcionArchivos($"Error al insertar un valor en la tabla.(SQL)", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Método que modifica turnos en la base de datos.
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        /// <exception cref="ExcepcionArchivos"></exception>
        public static bool ModificarPaciente(Paciente paciente)
        {
            try
            {
                command.CommandText = "UPDATE Pacientes SET Nombre = @Nombre, Apellido = @Apellido, Dni = @Dni, Mail = @Mail, Telefono = @Telefono, Fecha_Consulta = @Fecha_Consulta," +
                    " Horario = @Horario, Obra_social = @Obra_Social, Tipo_Consulta = @Tipo_Consulta WHERE Id = @Id";
                connection.Open();

                command.Parameters.AddWithValue("@Id", paciente.IdPaciente);
                command.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                command.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                command.Parameters.AddWithValue("@Dni", paciente.Dni);
                command.Parameters.AddWithValue("@Mail", paciente.Mail);
                command.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                command.Parameters.AddWithValue("@Fecha_Consulta", paciente.FechaConsulta);
                command.Parameters.AddWithValue("@Horario", paciente.Horario);
                command.Parameters.AddWithValue("@Obra_Social", paciente.ObraSocial.ToString());
                command.Parameters.AddWithValue("@Tipo_Consulta", paciente.TipoConsulta.ToString());

                command.ExecuteNonQuery();
                command.Parameters.Clear();

                return true;
            }
            catch (Exception ex)
            {

                throw new ExcepcionArchivos($"Error al modificar el turno(SQL)", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Método que elimina turnos en la base de datos.
        /// </summary>
        /// <param name="idPaciente"></param>
        /// <returns></returns>
        /// <exception cref="ExcepcionArchivos"></exception>
        public static bool EliminarPaciente(int idPaciente)
        {
            try
            {
                command.CommandText = "DELETE FROM Pacientes WHERE Id = @Id";
                connection.Open();

                command.Parameters.AddWithValue("@Id", idPaciente);

                command.ExecuteNonQuery();
                command.Parameters.Clear();

                return true;
            }
            catch (Exception ex)
            {
                throw new ExcepcionArchivos($"Error al guardar el archivo(SQL)", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Método que posee las consultas parametrizadas a la base de datos.
        /// </summary>
        /// <param name="paciente"></param>
        private static void QueryPacientes(Paciente paciente)
        {
            command.Parameters.AddWithValue("@Nombre", paciente.Nombre);
            command.Parameters.AddWithValue("@Apellido", paciente.Apellido);
            command.Parameters.AddWithValue("@Dni", paciente.Dni);
            command.Parameters.AddWithValue("@Mail", paciente.Mail);
            command.Parameters.AddWithValue("@Telefono", paciente.Telefono);
            command.Parameters.AddWithValue("@Fecha_Consulta", paciente.FechaConsulta);
            command.Parameters.AddWithValue("@Horario", paciente.Horario);
            command.Parameters.AddWithValue("@Obra_Social", paciente.ObraSocial.ToString());
            command.Parameters.AddWithValue("@Tipo_Consulta", paciente.TipoConsulta.ToString());
        }

        /// <summary>
        /// Método que obtiene los pacientes de la lista.
        /// </summary>
        /// <param name="pacientes"></param>
        /// <returns></returns>
        public static bool ObtenerPacientes(out List<Paciente> pacientes)
        {
            bool retorno = false;
            List<Paciente> listaPaciente = new List<Paciente>();
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {

                Enum.TryParse(dataReader["Obra_Social"].ToString(), out EObraSocial obraSocial);
                Enum.TryParse(dataReader["Tipo_Consulta"].ToString(), out ETipoConsulta tipoConsulta);

                Paciente pacienteDb = new Paciente(Convert.ToInt32(dataReader["Id"]), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(), dataReader["Dni"].ToString()
                    , dataReader["Mail"].ToString(), dataReader["Telefono"].ToString(), dataReader["Fecha_Consulta"].ToString(), dataReader["Horario"].ToString(),
                    obraSocial, tipoConsulta);

                listaPaciente.Add(pacienteDb);
                retorno = true;
            }
            pacientes = new List<Paciente>(listaPaciente);

            return retorno;
        }

        /// <summary>
        /// Método que lee turnos en la base de datos.
        /// </summary>
        /// <param name="pacientes"></param>
        /// <returns></returns>
        /// <exception cref="ExcepcionArchivos"></exception>
        public static bool Leer(out List<Paciente> pacientes)
        {
            try
            {
                command.CommandText = "SELECT * FROM Pacientes ORDER BY Fecha_Consulta ASC";
                connection.Open();

                if (ObtenerPacientes(out pacientes))
                {
                    return true;
                }

            }
            catch (Exception ex)
            {

                throw new ExcepcionArchivos(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return false;
        }
    }
}
