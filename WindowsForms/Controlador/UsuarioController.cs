using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using TuSaludEnTusHuesos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI.Relational;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Numerics;

namespace TuSaludEnTusHuesos.Controlador
{
    internal class UsuarioController
    {
        private ConexionBD conexionBD;

        public UsuarioController()
        {
            conexionBD = new ConexionBD();
        }

        public void InsertarDoctor(Doctor doctor)
        {
            // Obtener la conexión a la base de datos
            MySqlConnection conexion = conexionBD.ObtenerConexion();

            try
            {
                using (MySqlCommand comandoPersona = new MySqlCommand())
                {
                    comandoPersona.Connection = conexion;
                    comandoPersona.CommandText = "INSERT INTO Persona (nombre, apellido, direccion, telefono, email) VALUES (@nombre, @apellido, @direccion, @telefono, @email);";

                    // Agregar los parámetros para Persona
                    comandoPersona.Parameters.AddWithValue("@nombre", doctor.Nombre);
                    comandoPersona.Parameters.AddWithValue("@apellido", doctor.Apellido);
                    comandoPersona.Parameters.AddWithValue("@direccion", doctor.Direccion);
                    comandoPersona.Parameters.AddWithValue("@telefono", doctor.Telefono);
                    comandoPersona.Parameters.AddWithValue("@email", doctor.Email);

                    // Ejecutar la inserción y obtener el ID generado
                    comandoPersona.ExecuteNonQuery();
                    int idPersona = (int)comandoPersona.LastInsertedId;

                    // Ahora, insertar en la tabla Doctor
                    using (MySqlCommand comandoDoctor = new MySqlCommand())
                    {
                        comandoDoctor.Connection = conexion;
                        comandoDoctor.CommandText = "INSERT INTO Doctor (idPersona, idRol, usuario, contrasena, especialidad) VALUES (@idPersona, @idRol, @usuario, @contrasena, @especialidad);";

                        // Agregar los parámetros para Doctor
                        comandoDoctor.Parameters.AddWithValue("@idPersona", idPersona);
                        comandoDoctor.Parameters.AddWithValue("@idRol", doctor.IdRol);
                        comandoDoctor.Parameters.AddWithValue("@usuario", doctor.Usuario);
                        comandoDoctor.Parameters.AddWithValue("@contrasena", doctor.Contrasena);
                        comandoDoctor.Parameters.AddWithValue("@especialidad", doctor.Especialidad);

                        // Ejecutar la inserción
                        comandoDoctor.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al insertar el doctor: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conexionBD.CerrarConexion();
            }
        }

        public void InsertarAdministrador(Administrador administrador)
        {
            // Obtener la conexión a la base de datos
            MySqlConnection conexion = conexionBD.ObtenerConexion();

            try
            {
                using (MySqlCommand comandoPersona = new MySqlCommand())
                {
                    comandoPersona.Connection = conexion;
                    comandoPersona.CommandText = "INSERT INTO Persona (nombre, apellido, direccion, telefono, email) VALUES (@nombre, @apellido, @direccion, @telefono, @email);";

                    // Agregar los parámetros para Persona
                    comandoPersona.Parameters.AddWithValue("@nombre", administrador.Nombre);
                    comandoPersona.Parameters.AddWithValue("@apellido", administrador.Apellido);
                    comandoPersona.Parameters.AddWithValue("@direccion", administrador.Direccion);
                    comandoPersona.Parameters.AddWithValue("@telefono", administrador.Telefono);
                    comandoPersona.Parameters.AddWithValue("@email", administrador.Email);

                    // Ejecutar la inserción y obtener el ID generado
                    comandoPersona.ExecuteNonQuery();
                    int idPersona = (int)comandoPersona.LastInsertedId;

                    // Ahora, insertar en la tabla Administrador
                    using (MySqlCommand comandoAdmin = new MySqlCommand())
                    {
                        comandoAdmin.Connection = conexion;
                        comandoAdmin.CommandText = "INSERT INTO Administrador (idPersona, idRol, usuario, contrasena) VALUES (@idPersona, @idRol, @usuario, @contrasena);";

                        // Agregar los parámetros para Administrador
                        comandoAdmin.Parameters.AddWithValue("@idPersona", idPersona);
                        comandoAdmin.Parameters.AddWithValue("@idRol", administrador.IdRol);
                        comandoAdmin.Parameters.AddWithValue("@usuario", administrador.Usuario);
                        comandoAdmin.Parameters.AddWithValue("@contrasena", administrador.Contrasena);

                        // Ejecutar la inserción
                        comandoAdmin.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al insertar el administrador: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conexionBD.CerrarConexion();
            }
        }

        public void InsertarRecepcionista(Recepcionista recepcionista)
        {
            // Obtener la conexión a la base de datos
            MySqlConnection conexion = conexionBD.ObtenerConexion();

            try
            {
                using (MySqlCommand comandoPersona = new MySqlCommand())
                {
                    comandoPersona.Connection = conexion;
                    comandoPersona.CommandText = "INSERT INTO Persona (nombre, apellido, direccion, telefono, email) VALUES (@nombre, @apellido, @direccion, @telefono, @email);";

                    // Agregar los parámetros para Persona
                    comandoPersona.Parameters.AddWithValue("@nombre", recepcionista.Nombre);
                    comandoPersona.Parameters.AddWithValue("@apellido", recepcionista.Apellido);
                    comandoPersona.Parameters.AddWithValue("@direccion", recepcionista.Direccion);
                    comandoPersona.Parameters.AddWithValue("@telefono", recepcionista.Telefono);
                    comandoPersona.Parameters.AddWithValue("@email", recepcionista.Email);

                    // Ejecutar la inserción y obtener el ID generado
                    comandoPersona.ExecuteNonQuery();
                    int idPersona = (int)comandoPersona.LastInsertedId;

                    // Ahora, insertar en la tabla Recepcionista
                    using (MySqlCommand comandoRecepcionista = new MySqlCommand())
                    {
                        comandoRecepcionista.Connection = conexion;
                        comandoRecepcionista.CommandText = "INSERT INTO Recepcionista (idPersona, idRol, usuario, contrasena) VALUES (@idPersona, @idRol, @usuario, @contrasena);";

                        // Agregar los parámetros para Recepcionista
                        comandoRecepcionista.Parameters.AddWithValue("@idPersona", idPersona);
                        comandoRecepcionista.Parameters.AddWithValue("@idRol", recepcionista.IdRol);
                        comandoRecepcionista.Parameters.AddWithValue("@usuario", recepcionista.Usuario);
                        comandoRecepcionista.Parameters.AddWithValue("@contrasena", recepcionista.Contrasena);

                        // Ejecutar la inserción
                        comandoRecepcionista.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al insertar el recepcionista: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conexionBD.CerrarConexion();
            }
        }

        public List<UsuariosModel> ObtenerUsuarios()
        {
            List<UsuariosModel> listaUsuarios = new List<UsuariosModel>();

            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "SELECT a.idAdministrador as Id,CONCAT(p.nombre, \" \", p.apellido) as Nombre, a.usuario as Usuario, rr.nombreRol as Rol FROM administrador a\r\nINNER JOIN persona p ON a.idPersona = p.idPersona\r\nINNER JOIN rol rr ON rr.idRol = a.idRol\r\nUNION ALL\r\nSELECT d.idDoctor as Id,CONCAT(p.nombre, \" \", p.apellido) as Nombre, d.usuario as Usuario, rr.nombreRol FROM doctor d\r\nINNER JOIN persona p ON d.idPersona = p.idPersona\r\nINNER JOIN rol rr ON rr.idRol = d.idRol\r\nUNION ALL \r\nSELECT r.idRecepcionista as Id,CONCAT(p.nombre, \" \", p.apellido) as Nombre, r.usuario as Usuario, rr.nombreRol FROM recepcionista r\r\nINNER JOIN persona p ON r.idPersona = p.idPersona\r\nINNER JOIN rol rr ON rr.idRol = r.idRol";

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UsuariosModel usuarios = new UsuariosModel
                        {
                            id = reader.GetInt32("Id"),
                            nombre = reader.GetString("Nombre"),
                            usuario = reader.GetString("Usuario"),
                            rol = reader.GetString("Rol"),
                        };
                        listaUsuarios.Add(usuarios);
                    }
                }
            }
            conexionBD.CerrarConexion();

            return listaUsuarios;
        }

        //Editar usuario
        public void ActualizarUsuarios(UsuariosModel usuarios)
        {
            string query = string.Empty;
            int rol = 0;
            switch (usuarios.rol)
            {
                case "0":
                    query = "UPDATE `administrador`\r\nSET\r\n`idRol` = @rol,\r\n`usuario` = @usuario\r\nWHERE `idAdministrador` = @id";
                    rol = 1;
                    break;
                case "1":
                    query = "UPDATE `doctor`\r\nSET\r\n`idRol` = @rol,\r\n`usuario` = @usuario\r\nWHERE `idDoctor` = @id";
                    rol = 2;
                    break;
                case "2":
                    query = "UPDATE `recepcionista`\r\nSET\r\n`idRol` = @rol,\r\n`usuario` = @usuario\r\nWHERE `idRecepcionista` = @id";
                    rol = 3;
                     break;
                default:
                    break;
            }
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = query;
                comando.Parameters.AddWithValue("@usuario", usuarios.usuario);
                comando.Parameters.AddWithValue("@rol", rol);
                comando.Parameters.AddWithValue("@id", usuarios.id);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }

        //Eliminar Usuario
        public void EliminarUsuario(UsuariosModel usuario)
        {
            string query = string.Empty;
            int rol = 0;
            switch (usuario.rol)
            {
                case "0":
                    query = "DELETE FROM `administrador` WHERE `idAdministrador` = @id";
                    rol = 1;
                    break;
                case "1":
                    query = "DELETE FROM `doctor` WHERE `idDoctor` = @id";
                    rol = 2;
                    break;
                case "2":
                    query = "DELETE FROM `recepcionista` WHERE `idRecepcionista` = @id";
                    rol = 3;
                    break;
                default:
                    break;
            }
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = query;
                comando.Parameters.AddWithValue("@id", usuario.id);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }



        public int ObtenerIdClientePorNombreUsuario(string nombreUsuario)
        {
            int idCliente = -1; // Valor predeterminado en caso de que no se encuentre un cliente

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT id FROM Clientes WHERE id_usuario = (SELECT id FROM Usuarios WHERE usuario = @nombreUsuario)";
                        comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idCliente = reader.GetInt32("id");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones, muestra un mensaje de error o registra la excepción
                    Console.WriteLine("Error al obtener el ID de cliente: " + ex.Message);
                    MessageBox.Show("Error al obtener el ID de cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return idCliente;
        }



    }
}
