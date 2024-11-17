﻿using MySql.Data.MySqlClient;
using System;

namespace TuSaludEnTusHuesos.Modelo
{
    internal class ConexionBD : IDisposable
    {
        private MySqlConnection conexion;
        private string servidor = "127.0.0.1";
        private string baseDeDatos = "tusaludeth";
        private string usuario = "root";
        private string contraseña = "1234";

        public ConexionBD()
        {
            string cadenaConexion = $"Server={servidor};Database={baseDeDatos};User ID={usuario};Password={contraseña};";

            try
            {
                conexion = new MySqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al establecer la conexión a la base de datos: " + ex.Message);
            }
        }

        public MySqlConnection ObtenerConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public void Dispose()
        {
            CerrarConexion();
        }
    }
}
