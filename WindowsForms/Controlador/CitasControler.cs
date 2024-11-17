using MySql.Data.MySqlClient;
using TuSaludEnTusHuesos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace TuSaludEnTusHuesos.Controlador
{
    internal class CitasControler
    {
        private ConexionBD connection;

        public CitasControler() 
        {
            connection = new ConexionBD();
        }
        public bool CancelarCita(int id)
        {
            // Obtener los detalles del cliente (nombre y correo) de forma optimizada
            var (clienteNombre, clienteEmail) = ObtenerDatosCliente(id);
            bool resultado = false;

            // Obtener la conexión
            MySqlConnection conexion = connection.ObtenerConexion();

            try
            {
                // Asegurarse de que la conexión esté abierta
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                string query = "DELETE FROM cita WHERE idCita = @id";

                // Crear y configurar el comando
                using (MySqlCommand comando2 = new MySqlCommand(query, conexion))
                {
                    comando2.Parameters.AddWithValue("@id", id);

                    try
                    {
                        // Ejecutar la consulta y obtener el número de filas afectadas
                        int filasAfectadas = comando2.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            resultado = true;

                            // Enviar el correo electrónico al cliente
                            if (!string.IsNullOrEmpty(clienteEmail))
                            {
                                EnviarCorreoNotificacionCancelar(clienteEmail, clienteNombre);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Manejar la excepción de MySQL
                        Console.WriteLine("Error al eliminar la cita: " + ex.Message);
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Manejar excepciones de MySQL
                Console.WriteLine("Error MySQL: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión, solo una vez
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return resultado;
        }


        public List<CitasModelo> ObtenerCitas()
        {
            List<CitasModelo> listaCitas = new List<CitasModelo>();
            MySqlConnection conexion = connection.ObtenerConexion();
            string query = @"
        SELECT 
            C.idCita,
            C.fecha,
            C.hora,
            TC.nombreTipo AS tipoCita,
            CONCAT(DP.nombre, ' ', DP.apellido) AS doctor,
            D.especialidad,
            CONCAT(PP.nombre, ' ', PP.apellido) AS paciente
        FROM 
            Cita C
        JOIN 
            TipoCita TC ON C.idTipoCita = TC.idTipoCita
        JOIN 
            Doctor D ON C.idDoctor = D.idDoctor
        JOIN 
            Persona DP ON D.idPersona = DP.idPersona
        JOIN 
            Paciente P ON C.idPaciente = P.idPaciente
        JOIN 
            Persona PP ON P.idPersona = PP.idPersona
        WHERE 
            c.fecha >= CURDATE();";

            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = query;
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CitasModelo cita = new CitasModelo
                        {
                            IdCita = reader.GetInt32("idCita"),
                            Fecha = reader.GetDateTime("fecha"),
                            Hora = reader.GetTimeSpan("hora"),
                            TipoCita = reader.GetString("tipoCita"),
                            Doctor = reader.GetString("doctor"),
                            Especialidad = reader.GetString("especialidad"),
                            Paciente = reader.GetString("paciente")
                        };
                        listaCitas.Add(cita);
                    }
                }
            }
            connection.CerrarConexion();
            return listaCitas;
        }

        public bool ReprogramarFechaCita(CitasModelo cita)
        {
            bool resultado = false;
            MySqlConnection conexion = connection.ObtenerConexion();
            string query = "UPDATE cita SET fecha = @fecha WHERE idCita = @idCita";

            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = query;
                comando.Parameters.AddWithValue("@fecha", cita.Fecha);
                comando.Parameters.AddWithValue("@idCita", cita.IdCita);

                try
                {
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        resultado = true;

                        // Obtener los detalles del cliente (nombre y correo) de forma optimizada
                        var (clienteNombre, clienteEmail) = ObtenerDatosCliente(cita.IdCita);


                        // Enviar el correo electrónico al cliente
                        if (!string.IsNullOrEmpty(clienteEmail))
                        {
                            EnviarCorreoNotificacion(clienteEmail, clienteNombre, cita.Fecha);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error al modificar la fecha de la cita: " + ex.Message);
                }
                finally
                {
                    connection.CerrarConexion();
                }
            }

            return resultado;
        }
        private void EnviarCorreoNotificacion(string email, string nombre, DateTime nuevaFecha)
        {
            try
            {
                // Configuración del servidor SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("alexazf060@gmail.com", "hhqs wlah drhv etab"), // Usuario y contraseña de Gmail
                    EnableSsl = true // Habilitar SSL/TLS
                };

                // Crear el mensaje
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("alexazf060@gmail.com", "Tu Salud en Tus Huesos"),
                    Subject = "Reprogramación de Cita",
                    IsBodyHtml = true,
                    Body = $"¡Buen día {nombre} !<br><br>" +
                           $"Este correo es para informarte que tu cita ha sido reprogramada para el día {nuevaFecha}.<br>" +
                           "Si tienes alguna pregunta o necesitas más información, no dudes en contactarnos.<br><br>" +
                           "Atentamente,<br>" +
                           "Tu Salud en Tus Huesos, porque tu bienestar comienza desde adentro."
                };

                mailMessage.To.Add(new MailAddress(email, $"{nombre}")); // Receptor del correo

                // Enviar el correo
                smtpClient.Send(mailMessage);
                Console.WriteLine("Correo de reprogramación enviado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al enviar el correo: " + ex.Message);
            }
        }
        private (string nombreCompleto, string email) ObtenerDatosCliente(int idCita)
        {
            string nombreCompleto = string.Empty;
            string email = string.Empty;

            MySqlConnection conexion = connection.ObtenerConexion();
            string query = @"
                    SELECT CONCAT(p.nombre, ' ', p.apellido) AS nombreCompleto, p.email 
                    FROM Cita c
                    JOIN Paciente pac ON c.idPaciente = pac.idPaciente
                    JOIN Persona p ON pac.idPersona = p.idPersona
                    WHERE c.idCita = @idCita";

            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@idCita", idCita);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nombreCompleto = reader["nombreCompleto"].ToString();
                        email = reader["email"].ToString();
                    }
                }
            }

            connection.CerrarConexion();
            return (nombreCompleto, email);
        }


        public void EnviarCorreoNotificacionCancelar(string email, string nombre) {
            try
            {
                // Configuración del servidor SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("alexazf060@gmail.com", "hhqs wlah drhv etab"), // Usuario y contraseña de Gmail
                    EnableSsl = true // Habilitar SSL/TLS
                };

                // Crear el mensaje
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("alexazf060@gmail.com", "Tu Salud en Tus Huesos"),
                    Subject = "Cancelación de Cita",
                    IsBodyHtml = true,
                    Body = $"¡Buen día {nombre} !<br><br>" +
                           $"Este correo es para informarte que tu cita fue cancelada por motivos de fuerza mayor.<br>" +
                           "Si tienes alguna pregunta o necesitas más información, no dudes en contactarnos.<br><br>" +
                           "Atentamente,<br>" +
                           "Tu Salud en Tus Huesos, porque tu bienestar comienza desde adentro."
                };

                mailMessage.To.Add(new MailAddress(email, $"{nombre}")); // Receptor del correo

                // Enviar el correo
                smtpClient.Send(mailMessage);
                Console.WriteLine("Correo de reprogramación enviado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al enviar el correo: " + ex.Message);
            }
        }
    }
}
