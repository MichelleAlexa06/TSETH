using MySql.Data.MySqlClient;
using TuSaludEnTusHuesos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TuSaludEnTusHuesos.Controlador
{
    internal class LoginController
    {
        private ConexionBD conexion;

        public LoginController()
        {
            conexion = new ConexionBD();
        }

        public bool AutenticarUsuario( string usuario, string pass, int rol)
        {          
            try
            {
                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    string query = string.Empty;
                    switch (rol)
                    {
                        case 1:
                            query = "SELECT * FROM administrador WHERE usuario = @usuario AND contrasena = @pass";
                            break;
                        case 2:
                            query = "SELECT * FROM doctor WHERE usuario = @usuario AND contrasena = @pass";
                            break;
                        case 3:
                            query = "SELECT * FROM recepcionista WHERE usuario = @usuario AND contrasena = @pass";
                            break;
                        default:
                            return false;                            
                    }                  
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@pass", pass);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar el usuario: " + ex.Message);
            }

            return false;
        }


    }
}
