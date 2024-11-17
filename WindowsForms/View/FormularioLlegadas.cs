using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class FormularioLlegadas : Form
    {
        LlegadasController llegadasController = new LlegadasController();
        public FormularioLlegadas(string usuario)
        {
            InitializeComponent();



        }
        private void MostrarIdCliente(int idCliente)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {


        }

        private void FormularioLicitaciones_Load(object sender, EventArgs e)
        {
            CargarCitasEnComboBox();
        }
        private void CargarCitasEnComboBox()
        {
            // Llama al método del controlador para obtener la lista de citas.
            List<CitasModelo> citas = llegadasController.ObtenerCitas();

            // Configura el ComboBox.
            cbbCitas.DataSource = citas;
            cbbCitas.DisplayMember = "Paciente"; // Campo que se mostrará en el ComboBox.
            cbbCitas.ValueMember = "IdCita"; // Campo que se usará como valor interno (índice).

            // Opcional: agrega un ítem de selección predeterminado.
            cbbCitas.SelectedIndex = -1; // Deja el ComboBox sin selección inicial.
        }

        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSleccionarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarLicitacion_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles en el formulario
            int idCita = Convert.ToInt32(cbbCitas.SelectedValue.ToString());
            DateTime fechaLlegada = dtpFecha.Value;
            TimeSpan HoraLlegada = dtpHora.Value.TimeOfDay;

            if (cbbCitas.SelectedIndex == -1 || string.IsNullOrEmpty(cbbCitas.SelectedValue?.ToString()))
            {
                // Muestra un mensaje de error si uno o más campos están vacíos
                MessageBox.Show("Por favor, seleccione la cita para el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si hay campos vacíos
            }
            LlegadasModel llegadasModel = new LlegadasModel();
            llegadasModel.IdCita = idCita;
            llegadasModel.FechaLlegada = fechaLlegada;
            llegadasModel.HoraLlegada = HoraLlegada;
            // Validar y convertir el ID del cliente
            if (!llegadasController.AgregarRegistroLlegada(llegadasModel))
            {
                MessageBox.Show("Error al registrar la llegadas. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            // Inserción exitosa, muestra un mensaje de confirmación
            MessageBox.Show("Registro de llegada agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();


        }
       
        private void CargarDatosDeLicitacion(int idLicitacion)
        {
          
        }




        // Método para limpiar los campos del formulario después de agregar una licitación
        private void LimpiarCampos()
        {
            cbbCitas.SelectedIndex = -1;
        }







    }
}
