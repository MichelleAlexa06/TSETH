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
    public partial class FormularioExpediente1 : Form
    {
        private ExpedienteController expController  = new ExpedienteController();
        public FormularioExpediente1()
        {
            InitializeComponent();

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Recopila los datos del cliente desde los controles en el formulario
            ExpedienteModel exp = new ExpedienteModel();
            // Asignar valores al objeto desde el formulario
            exp.IdRegistroLlegada = (int)cbbRegistrollegada.SelectedValue;
            exp.IdPaciente = (int)cbbPaciente.SelectedValue;
            exp.IdRecepcionista = (int)cbbRecep.SelectedValue;
            exp.IdDoctor = (int)cbbDoctor.SelectedValue;

            exp.Edad = string.IsNullOrEmpty(cbbEdad.Text) ? 0 : int.Parse(cbbEdad.Text); // Convertir a entero si es necesario
            exp.Sexo = cbbSex.SelectedItem.ToString();
            exp.EstadoCivil = txtEstado.Text;
            exp.GrupoSanguineo = cbbSangre.SelectedItem.ToString();
            exp.FactorRH = cbbTipoSangre.SelectedItem.ToString();

            exp.AlergiasConocidas = txtAlergia.Text;
            exp.CondicionesPreexistentes = txtCondiciones.Text;
            exp.MedicamentosActuales = txtMedicamento.Text;
            exp.VacunasRecibidas = txtVacuna.Text;
            exp.HistorialEnfermedades = txtPrevEnfer.Text;
            exp.CirugiasPrevias = txtPreCir.Text;
            exp.HospitalizacionesPrevias = txtPreHos.Text;
            exp.HistorialFamiliar = txtEnfHE.Text;

            exp.NombreContactoEmergencia = txtContacto.Text;
            exp.RelacionContactoEmergencia = txtParentesco.Text;
            exp.TelefonoContactoEmergencia = txtTele.Text;
            exp.DireccionContactoEmergencia = txtDireccion.Text;


            // Verificación de campos vacíos para ExpedienteModel
            if (cbbRegistrollegada.SelectedIndex == -1 ||
                cbbPaciente.SelectedIndex == -1 ||
                cbbRecep.SelectedIndex == -1 ||
                cbbDoctor.SelectedIndex == -1 ||
                string.IsNullOrEmpty(cbbEdad.Text) ||
                cbbSex.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtEstado.Text) ||
                cbbSangre.SelectedIndex == -1 ||
                cbbTipoSangre.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtAlergia.Text) ||
                string.IsNullOrEmpty(txtCondiciones.Text) ||
                string.IsNullOrEmpty(txtMedicamento.Text) ||
                string.IsNullOrEmpty(txtVacuna.Text) ||
                string.IsNullOrEmpty(txtPrevEnfer.Text) ||
                string.IsNullOrEmpty(txtPreCir.Text) ||
                string.IsNullOrEmpty(txtPreHos.Text) ||
                string.IsNullOrEmpty(txtEnfHE.Text) ||
                string.IsNullOrEmpty(txtContacto.Text) ||
                string.IsNullOrEmpty(txtParentesco.Text) ||
                string.IsNullOrEmpty(txtTele.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la operación si hay campos vacíos
            }


            // Llama al método para insertar el cliente
            try
            {
                if (!expController.InsertarExpediente(exp)) {
                    MessageBox.Show("Error al insertar el expediente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Expediente insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuariosEnComboBox();
                // Limpia los campos después de insertar el cliente
                Limpiar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Limpiar()
        {
            cbbRegistrollegada.SelectedIndex = -1;
            cbbPaciente.SelectedIndex = -1;
            cbbRecep.SelectedIndex = -1;
            cbbDoctor.SelectedIndex = -1;
            cbbEdad.Text = string.Empty;
            cbbSex.SelectedIndex = -1;
            txtEstado.Text = string.Empty;
            cbbSangre.SelectedIndex = -1;
            cbbTipoSangre.SelectedIndex = -1;
            txtAlergia.Text = string.Empty;
            txtCondiciones.Text = string.Empty;
            txtMedicamento.Text = string.Empty;
            txtVacuna.Text = string.Empty;
            txtPrevEnfer.Text = string.Empty;
            txtPreCir.Text = string.Empty;
            txtPreHos.Text = string.Empty;
            txtEnfHE.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtParentesco.Text = string.Empty;
            txtTele.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }
        
        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            CargarUsuariosEnComboBox();
            Limpiar();
        }
        private void CargarUsuariosEnComboBox()
        {
            // Llenar el ComboBox de Doctor
            cbbDoctor.DataSource = expController.ObtenerDatosDoctor();
            cbbDoctor.DisplayMember = "NombreCompleto";  // Mostrar Nombre Completo
            cbbDoctor.ValueMember = "id";  // Usar idDoctor como valor

            // Llenar el ComboBox de Recepcionista
            cbbRecep.DataSource = expController.ObtenerDatosRecepcionista();
            cbbRecep.DisplayMember = "NombreCompleto";  // Mostrar Nombre Completo
            cbbRecep.ValueMember = "id";  // Usar idRecepcionista como valor

            // Llenar el ComboBox de Paciente
            cbbPaciente.DataSource = expController.ObtenerDatosPaciente();
            cbbPaciente.DisplayMember = "NombreCompleto";  // Mostrar Nombre Completo
            cbbPaciente.ValueMember = "id";  // Usar idPaciente como valor

            // Llenar el ComboBox de Registro Llegada
            cbbRegistrollegada.DataSource = expController.ObtenerDatosRegistroLlegada();
            cbbRegistrollegada.DisplayMember = "NombreCompleto";  // Mostrar Fecha Llegada
            cbbRegistrollegada.ValueMember = "id";  // Usar idRegistro como valor
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
