using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuSaludEnTusHuesos.Modelo;

namespace TuSaludEnTusHuesos.Controlador
{
    internal class ReportController
    {
        private ConexionBD connection;

        public ReportController()
        {
            connection = new ConexionBD();
        }
        public List<ExpedienteReport> ObtenerExpedientesPorDoctor(int idDoctor, string fechaInicio, string fechaFin)
        {
            List<ExpedienteReport> expedientes = new List<ExpedienteReport>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        string query = @"
                    SELECT e.idExpediente, 
                           CONCAT(per.nombre, ' ', per.apellido) AS NombrePaciente,
                           e.fechaCreacion AS FechaCreacion,
                           e.estadoCivil AS EstadoCivil,
                           e.grupoSanguineo AS GrupoSanguineo,
                           e.factorRH AS FactorRH,
                           e.motivoConsulta AS MotivoConsulta
                    FROM Expediente e
                    JOIN Paciente p ON e.idPaciente = p.idPaciente
                    JOIN Persona per ON p.idPersona = per.idPersona
                    WHERE e.idDoctor = @idDoctor
                    AND e.fechaCreacion >= @fechaInicio
                    AND e.fechaCreacion <= @fechaFin;";

                        comando.CommandText = query;
                        comando.Parameters.AddWithValue("@idDoctor", idDoctor);
                        comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        comando.Parameters.AddWithValue("@fechaFin", fechaFin);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                expedientes.Add(new ExpedienteReport
                                {
                                    IdExpediente = reader.GetInt32("idExpediente"),
                                    NombrePaciente = reader.GetString("NombrePaciente"),
                                    FechaCreacion = reader.GetDateTime("FechaCreacion"),
                                    EstadoCivil = reader.IsDBNull(reader.GetOrdinal("EstadoCivil")) ? string.Empty : reader.GetString("EstadoCivil"),
                                    GrupoSanguineo = reader.IsDBNull(reader.GetOrdinal("GrupoSanguineo")) ? string.Empty : reader.GetString("GrupoSanguineo"),
                                    FactorRH = reader.IsDBNull(reader.GetOrdinal("FactorRH")) ? string.Empty : reader.GetString("FactorRH"),
                                    MotivoConsulta = reader.IsDBNull(reader.GetOrdinal("MotivoConsulta")) ? string.Empty : reader.GetString("MotivoConsulta")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los expedientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return expedientes;
        }

        public List<CitaReport> ObtenerCitasPorPaciente(string fechaInicio, string fechaFin)
        {
            List<CitaReport> citas = new List<CitaReport>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        string query = @"
                        SELECT 
                            c.idCita, 
                            CONCAT(per.nombre, ' ', per.apellido) AS NombrePaciente,
                            c.fecha AS FechaCita,
                            c.hora AS HoraCita,
                            CONCAT(docPersona.nombre, ' ', docPersona.apellido) AS NombreDoctor,
                            tc.nombreTipo AS TipoCita
                        FROM Cita c
                        JOIN Paciente p ON c.idPaciente = p.idPaciente
                        JOIN Persona per ON p.idPersona = per.idPersona
                        JOIN Doctor d ON c.idDoctor = d.idDoctor
                        JOIN Persona docPersona ON d.idPersona = docPersona.idPersona
                        JOIN TipoCita tc ON c.idTipoCita = tc.idTipoCita
                        WHERE 
                            c.fecha >= @fechaInicio
                        AND 
                            c.fecha <= @fechaFin;";

                        comando.CommandText = query;
                        comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        comando.Parameters.AddWithValue("@fechaFin", fechaFin);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                citas.Add(new CitaReport
                                {
                                    IdCita = reader.GetInt32("idCita"),
                                    NombrePaciente = reader.GetString("NombrePaciente"),
                                    FechaCita = reader.GetDateTime("FechaCita"),
                                    HoraCita = reader.GetTimeSpan("HoraCita"),
                                    NombreDoctor = reader.GetString("NombreDoctor"),
                                    TipoCita = reader.GetString("TipoCita")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener las citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return citas;
        }

    }
}
