using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TuSaludEnTusHuesos.Modelo
{
    internal class UsuariosModel
    {
        private int Id;
        private string Nombre;
        private string Usuario;
        private string Rol;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        public string rol
        {
            get { return Rol; }
            set { Rol = value; }
        }



    }
}
