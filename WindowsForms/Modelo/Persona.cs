using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSaludEnTusHuesos.Modelo
{
    // Clase base: Persona
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        // Constructor vacío
        public Persona() { }

        // Constructor con parámetros
        public Persona(int idPersona, string nombre, string apellido, string direccion, string telefono, string email)
        {
            IdPersona = idPersona;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }
    }

    // Clase Administrador
    public class Administrador : Persona
    {
        public int IdAdministrador { get; set; }
        public int IdRol { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        // Constructor vacío
        public Administrador() { }

        // Constructor con parámetros
        public Administrador(int idAdministrador, int idPersona, string nombre, string apellido, string direccion, string telefono, string email, int idRol, string usuario, string contrasena)
            : base(idPersona, nombre, apellido, direccion, telefono, email)
        {
            IdAdministrador = idAdministrador;
            IdRol = idRol;
            Usuario = usuario;
            Contrasena = contrasena;
        }
    }

    // Clase Doctor
    public class Doctor : Persona
    {
        public int IdDoctor { get; set; }
        public int IdRol { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Especialidad { get; set; }

        // Constructor vacío
        public Doctor() { }

        // Constructor con parámetros
        public Doctor(int idDoctor, int idPersona, string nombre, string apellido, string direccion, string telefono, string email, int idRol, string usuario, string contrasena, string especialidad)
            : base(idPersona, nombre, apellido, direccion, telefono, email)
        {
            IdDoctor = idDoctor;
            IdRol = idRol;
            Usuario = usuario;
            Contrasena = contrasena;
            Especialidad = especialidad;
        }
    }

    // Clase Recepcionista
    public class Recepcionista : Persona
    {
        public int IdRecepcionista { get; set; }
        public int IdRol { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        // Constructor vacío
        public Recepcionista() { }

        // Constructor con parámetros
        public Recepcionista(int idRecepcionista, int idPersona, string nombre, string apellido, string direccion, string telefono, string email, int idRol, string usuario, string contrasena)
            : base(idPersona, nombre, apellido, direccion, telefono, email)
        {
            IdRecepcionista = idRecepcionista;
            IdRol = idRol;
            Usuario = usuario;
            Contrasena = contrasena;
        }
    }

}
