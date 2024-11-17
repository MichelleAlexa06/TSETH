using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using TuSaludEnTusHuesos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSaludEnTusHuesos.Controlador
{
    internal class ExpedienteController
    {
        private ConexionBD conexionBD;

        public ExpedienteController()
        {
            conexionBD = new ConexionBD();
        }

        public bool InsertarExpediente(ExpedienteModel expediente)
        {
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;

                        string query = @"
                            INSERT INTO Expediente (
                                idRegistroLlegada, idPaciente, idRecepcionista, idDoctor, edad, sexo, 
                                estadoCivil, grupoSanguineo, factorRH, alergiasConocidas, 
                                condicionesPreexistentes, medicamentosActuales, vacunasRecibidas, 
                                historialEnfermedades, cirugiasPrevias, hospitalizacionesPrevias, 
                                historialFamiliar, nombreContactoEmergencia, relacionContactoEmergencia, 
                                telefonoContactoEmergencia, direccionContactoEmergencia
                            ) VALUES (
                                @IdRegistroLlegada, @IdPaciente, @IdRecepcionista, @IdDoctor, @Edad, @Sexo, 
                                @EstadoCivil, @GrupoSanguineo, @FactorRH, @AlergiasConocidas, 
                                @CondicionesPreexistentes, @MedicamentosActuales, @VacunasRecibidas, 
                                @HistorialEnfermedades, @CirugiasPrevias, @HospitalizacionesPrevias, 
                                @HistorialFamiliar, @NombreContactoEmergencia, @RelacionContactoEmergencia, 
                                @TelefonoContactoEmergencia, @DireccionContactoEmergencia
                            );
                        ";

                        comando.CommandText = query;
                        // Asignar parámetros
                        comando.Parameters.AddWithValue("@IdRegistroLlegada", expediente.IdRegistroLlegada);
                        comando.Parameters.AddWithValue("@IdPaciente", expediente.IdPaciente);
                        comando.Parameters.AddWithValue("@IdRecepcionista", expediente.IdRecepcionista);
                        comando.Parameters.AddWithValue("@IdDoctor", expediente.IdDoctor);
                        comando.Parameters.AddWithValue("@Edad", expediente.Edad);
                        comando.Parameters.AddWithValue("@Sexo", expediente.Sexo);
                        comando.Parameters.AddWithValue("@EstadoCivil", expediente.EstadoCivil);
                        comando.Parameters.AddWithValue("@GrupoSanguineo", expediente.GrupoSanguineo);
                        comando.Parameters.AddWithValue("@FactorRH", expediente.FactorRH);
                        comando.Parameters.AddWithValue("@AlergiasConocidas", expediente.AlergiasConocidas);
                        comando.Parameters.AddWithValue("@CondicionesPreexistentes", expediente.CondicionesPreexistentes);
                        comando.Parameters.AddWithValue("@MedicamentosActuales", expediente.MedicamentosActuales);
                        comando.Parameters.AddWithValue("@VacunasRecibidas", expediente.VacunasRecibidas);
                        comando.Parameters.AddWithValue("@HistorialEnfermedades", expediente.HistorialEnfermedades);
                        comando.Parameters.AddWithValue("@CirugiasPrevias", expediente.CirugiasPrevias);
                        comando.Parameters.AddWithValue("@HospitalizacionesPrevias", expediente.HospitalizacionesPrevias);
                        comando.Parameters.AddWithValue("@HistorialFamiliar", expediente.HistorialFamiliar);
                        comando.Parameters.AddWithValue("@NombreContactoEmergencia", expediente.NombreContactoEmergencia);
                        comando.Parameters.AddWithValue("@RelacionContactoEmergencia", expediente.RelacionContactoEmergencia);
                        comando.Parameters.AddWithValue("@TelefonoContactoEmergencia", expediente.TelefonoContactoEmergencia);
                        comando.Parameters.AddWithValue("@DireccionContactoEmergencia", expediente.DireccionContactoEmergencia);

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();
                        return true; // Si todo va bien, retornamos true
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, se captura la excepción y se retorna false
                    Console.WriteLine("Error al insertar el expediente: " + ex.Message);
                    return false;
                }
            }
        }

        public bool ActualizarExpediente(int idExpediente, ExpedienteModel expediente)
        {
            DateTime fecha = DateTime.Now;
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;

                        string query = @"
                            UPDATE Expediente
                            SET 
                                motivoConsulta = @MotivoConsulta,
                                sintomasActuales = @SintomasActuales,
                                diagnosticoPreliminar = @DiagnosticoPreliminar,
                                tratamientoRecomendaciones = @TratamientoRecomendaciones,
                                fechaCreacion = @FechaCreacion
                            WHERE idExpediente = @IdExpediente;
                        ";

                        comando.CommandText = query;
                        // Asignar parámetros
                        comando.Parameters.AddWithValue("@IdExpediente", idExpediente);
                        comando.Parameters.AddWithValue("@MotivoConsulta", expediente.MotivoConsulta);
                        comando.Parameters.AddWithValue("@SintomasActuales", expediente.SintomasActuales);
                        comando.Parameters.AddWithValue("@DiagnosticoPreliminar", expediente.DiagnosticoPreliminar);
                        comando.Parameters.AddWithValue("@TratamientoRecomendaciones", expediente.TratamientoRecomendaciones);
                        comando.Parameters.AddWithValue("@FechaCreacion", fecha);

                        // Ejecutar la consulta
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            return true; // Si se afectaron filas, retornamos true
                        }
                        else
                        {
                            return false; // Si no se encontró el expediente con el ID, retornamos false
                        }
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, se captura la excepción y se retorna false
                    Console.WriteLine("Error al actualizar el expediente: " + ex.Message);
                    return false;
                }
            }
        }


        public List<ExpedienteModel> ObtenerExpedienteRe()
        {
            List<ExpedienteModel> listaExpe = new List<ExpedienteModel>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    // No es necesario abrir la conexión manualmente, ya que se hace automáticamente dentro del using

                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT id, nombre, email, telefono, empresa, id_usuario FROM Clientes";

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ExpedienteModel expediente = new ExpedienteModel
                                {
                                    //Id = reader.GetInt32("id"),
                                    //Nombre = reader.GetString("nombre"),
                                    //Email = reader.GetString("email"),
                                    //Telefono = reader.GetString("telefono"),
                                    //Empresa = reader.GetString("empresa"),
                                    //IdUsuario = reader.GetInt32("id_usuario")
                                };
                                listaExpe.Add(expediente);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones, muestra un mensaje de error o registra la excepción
                    MessageBox.Show("Error al obtener los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // La conexión se cerrará automáticamente al salir del bloque 'using'
            }

            return listaExpe;
        }

        // Obtener datos de los Doctores
        public List<ComboBoxItem> ObtenerDatosDoctor()
        {
            List<ComboBoxItem> doctores = new List<ComboBoxItem>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        string query = @"
                    SELECT d.idDoctor, CONCAT(p.nombre, ' ', p.apellido) as NombreCompleto
                    FROM Doctor d
                    JOIN Persona p ON d.idPersona = p.idPersona";
                        comando.CommandText = query;
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                doctores.Add(new ComboBoxItem
                                {
                                    id = reader.GetInt32("idDoctor"),
                                    NombreCompleto = reader.GetString("NombreCompleto")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los doctores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return doctores;
        }

        // Obtener datos de los Recepcionistas
        public List<ComboBoxItem> ObtenerDatosRecepcionista()
        {
            List<ComboBoxItem> recepcionistas = new List<ComboBoxItem>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        string query = @"
                    SELECT r.idRecepcionista, CONCAT(p.nombre, ' ', p.apellido) as NombreCompleto
                    FROM Recepcionista r
                    JOIN Persona p ON r.idPersona = p.idPersona";
                        comando.CommandText = query;
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                recepcionistas.Add(new ComboBoxItem
                                {
                                    id = reader.GetInt32("idRecepcionista"),
                                    NombreCompleto = reader.GetString("NombreCompleto")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los recepcionistas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return recepcionistas;
        }

        // Obtener datos de los Pacientes
        public List<ComboBoxItem> ObtenerDatosPaciente()
        {
            List<ComboBoxItem> pacientes = new List<ComboBoxItem>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        string query = @"
                        SELECT p.idPaciente, CONCAT(per.nombre, ' ', per.apellido) as NombreCompleto
                        FROM Paciente p
                        JOIN Persona per ON p.idPersona = per.idPersona";
                        comando.CommandText = query;
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pacientes.Add(new ComboBoxItem
                                {
                                    id = reader.GetInt32("idPaciente"),
                                    NombreCompleto = reader.GetString("NombreCompleto")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return pacientes;
        }

        // Obtener datos de los Registros de Llegada
        public List<ComboBoxItem> ObtenerDatosRegistroLlegada()
        {
            List<ComboBoxItem> registros = new List<ComboBoxItem>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        string query = @"
                    SELECT r.idRegistro, 
                           CONCAT(r.fechaLlegada, ' - ', per.nombre, ' ', per.apellido) AS NombreCompleto
                    FROM RegistroLlegada r
                    JOIN Cita c ON r.idCita = c.idCita
                    JOIN Paciente p ON c.idPaciente = p.idPaciente
                    JOIN Persona per ON p.idPersona = per.idPersona
                    WHERE r.fechaLlegada >= CURDATE();  -- Condición para que la fecha sea mayor o igual a hoy
                    ";
                        comando.CommandText = query;

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                registros.Add(new ComboBoxItem
                                {
                                    id = reader.GetInt32("idRegistro"),
                                    NombreCompleto = reader.GetString("NombreCompleto")  // Nombre con fecha
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los registros de llegada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return registros;
        }

        public List<ComboBoxItem> ObtenerExpedientesPorDoctor(int idDoctor)
        {
            List<ComboBoxItem> expedientes = new List<ComboBoxItem>();

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
                           CONCAT(per.nombre, ' ', per.apellido) AS NombrePaciente
                    FROM Expediente e
                    JOIN Paciente p ON e.idPaciente = p.idPaciente
                    JOIN Persona per ON p.idPersona = per.idPersona
                    WHERE e.idDoctor = @idDoctor;";  // Filtra por el idDoctor actual

                        comando.CommandText = query;
                        comando.Parameters.AddWithValue("@idDoctor", idDoctor);  // Asignamos el valor del doctor actual

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                expedientes.Add(new ComboBoxItem
                                {
                                    id = reader.GetInt32("idExpediente"),  // Asignamos el idExpediente como id
                                    NombreCompleto = reader.GetString("NombrePaciente")  // Asignamos el nombre del paciente
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

        public int ObtenerIdDoctorPorUsername(string username)
        {
            int idDoctor = -1; // Valor por defecto en caso de que no se encuentre el doctor

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        string query = @"
                    SELECT idDoctor 
                    FROM Doctor 
                    WHERE usuario = @username";  // Buscamos el doctor por su username

                        comando.CommandText = query;
                        comando.Parameters.AddWithValue("@username", username);  // Pasamos el username como parámetro

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idDoctor = reader.GetInt32("idDoctor");  // Asignamos el idDoctor obtenido
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el idDoctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return idDoctor;
        }


    }
}
