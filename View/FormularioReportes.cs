using TuSaludEnTusHuesos.Controlador;
using TuSaludEnTusHuesos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuSaludEnTusHuesos.View
{
    public partial class FormularioReportes : Form
    {
        public FormularioReportes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioReporDoctor form = new FormularioReporDoctor();
            // Mostrar el formulario de proveedores
            form.ShowDialog();
        }  

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormularioReporCita form = new FormularioReporCita();
            form.ShowDialog();
        }     
    }
}
