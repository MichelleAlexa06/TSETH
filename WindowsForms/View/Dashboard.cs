using TuSaludEnTusHuesos.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuSaludEnTusHuesos.Modelo;

namespace TuSaludEnTusHuesos.View
{
    public partial class Dashboard : Form
    {

        private string rolUsuario;
        private string usuario;
        private string doctorUser;

        public Dashboard(string usuario, string rolUsuario, string doctorUser)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rolUsuario = rolUsuario;
            this.doctorUser = doctorUser;

            MostrarBotonesSegunRol();
            lblUsuario.Text = usuario + "\n";
            lblRol.Text = rolUsuario + "\n";

        }
        //ocultar botones 
        private void MostrarBotonesSegunRol()
        {
            if (rolUsuario == "Recepcionista")
            {
                //btnClientes.Visible = false;
                //btnProveedor.Visible = false;
                btnUsuarios.Visible = false;


            }
            if (rolUsuario == "Doctor")
            {
                btnProveedor.Visible = false;
                //btnClientes.Visible = false;
                btnLicitacion.Visible = false;
                btnUsuarios.Visible = false;
                btnPropuesta.Visible = false;
            }

        }
        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (rolUsuario == "Recepcionista")
            {
                // Crear una instancia del formulario de clientes
                FormularioExpediente1 formClientes = new FormularioExpediente1();

                // Mostrar el formulario de clientes (modal) - Bloquea Form1 hasta que se cierre el formulario de clientes
                formClientes.ShowDialog();
            }
            else if (rolUsuario == "Doctor")
            {
                // Crear una instancia del formulario de clientes
                FormularioExpediente2 formClientes = new FormularioExpediente2(doctorUser);

                // Mostrar el formulario de clientes (modal) - Bloquea Form1 hasta que se cierre el formulario de clientes
                formClientes.ShowDialog();
            }
            else {
                MessageBox.Show("Acceda como Doctor / Recepcionista, para ver este apartado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de proveedores
            FormularioReportes formProveedores = new FormularioReportes();

            // Mostrar el formulario de proveedores
            formProveedores.ShowDialog();
        }

        private void btnLicitacion_Click(object sender, EventArgs e)
        {
            FormularioLlegadas licitaciones = new FormularioLlegadas(usuario);

            licitaciones.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormularioUsuarios frmUsuarios = new FormularioUsuarios();

            frmUsuarios.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPropuesta_Click(object sender, EventArgs e)
        {
            FormularioCita frmPropuestas = new FormularioCita();
            frmPropuestas.ShowDialog();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
