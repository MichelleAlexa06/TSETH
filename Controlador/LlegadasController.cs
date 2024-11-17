using MySql.Data.MySqlClient;
using TuSaludEnTusHuesos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TuSaludEnTusHuesos.Controlador
{
    internal class LlegadasController
    {
        private ConexionBD connection;

        public LlegadasController()
        {
            connection = new ConexionBD();
        }

        public bool AgregarRegistroLlegada(LlegadasModel llegadas)
        {
            bool result = false;
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    string query = @"
                        INSERT INTO RegistroLlegada (idCita, fechaLlegada, horaLlegada)
                        VALUES (@idCita, @fechaLlegada, @horaLlegada);
                    ";
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText =query;
                        comando.Parameters.AddWithValue("@idCita", llegadas.IdCita);
                        comando.Parameters.AddWithValue("@fechaLlegada", llegadas.FechaLlegada);
                        comando.Parameters.AddWithValue("@horaLlegada", llegadas.HoraLlegada);
                        comando.ExecuteNonQuery();
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al insertar la licitación: " + ex.Message);
                    
                }
            }
            return result;
        }

        public List<CitasModelo> ObtenerCitas()
        {
            List<CitasModelo> citas = new List<CitasModelo>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        string query = @"
                            SELECT c.idCita, CONCAT (p.nombre,"" "", p.apellido) as Nombre
                            FROM Cita c
                            JOIN Paciente pa ON c.idPaciente = pa.idPaciente
                            JOIN Persona p ON pa.idPersona = p.idPersona
                            WHERE c.fecha >= CURDATE();
                        ";
                        comando.CommandText = query;
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CitasModelo llegadas = new CitasModelo
                                {
                                    IdCita = reader.GetInt32("idCita"),
                                    Paciente = reader.GetString("Nombre"),
                                };
                                citas.Add(llegadas);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener las licitaciones: " + ex.Message);
                }
            }

            return citas;
        }







    }
}
