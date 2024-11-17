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
    public partial class FormularioExpediente2 : Form
    {
        private ExpedienteController expediente = new ExpedienteController();
        private string doctor;
        public FormularioExpediente2(string doctor)
        {
            InitializeComponent();
            this.doctor = doctor;   
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Recopila los datos del cliente desde los controles en el formulario
            
            ExpedienteModel expp = new ExpedienteModel();
            expp.MotivoConsulta = txtMotivo.Text;
            expp.SintomasActuales = txtSintomas.Text;
            expp.DiagnosticoPreliminar = txtDiagnostico.Text;
            expp.TratamientoRecomendaciones = txtTratamiento.Text;

            int valor = (int)cbbExpAsignado.SelectedValue;
            // Verifica si algún campo está vacío
            if (string.IsNullOrEmpty(expp.MotivoConsulta) || string.IsNullOrEmpty(expp.SintomasActuales) || string.IsNullOrEmpty(expp.TratamientoRecomendaciones) || string.IsNullOrEmpty(expp.DiagnosticoPreliminar) || cbbExpAsignado.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la operación si hay campos vacíos
            }

            // Llama al método para insertar el expediente
            try
            {
                if (!expediente.ActualizarExpediente(valor,expp)) {
                    MessageBox.Show("Error al insertar el expediente: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Expediente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia los campos después de insertar el expediente
                CargarExpe();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el expediente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Limpiar()
        {
            cbbExpAsignado.SelectedIndex = -1;
            txtMotivo.Text = string.Empty;
            txtSintomas.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            txtTratamiento.Text = string.Empty;
        }
       
        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            CargarExpe();
        }
       



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

      



        private void CargarExpe()
        {
            int val = expediente.ObtenerIdDoctorPorUsername(doctor);
            // Llenar el ComboBox de Doctor
            cbbExpAsignado.DataSource = expediente.ObtenerExpedientesPorDoctor(val);
            cbbExpAsignado.DisplayMember = "NombreCompleto";  // Mostrar Nombre Completo
            cbbExpAsignado.ValueMember = "id";  // Usar idDoctor como valor

        }
    }
}
