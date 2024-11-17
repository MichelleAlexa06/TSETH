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
    public partial class FormularioCita : Form
    {
        private CitasControler citasController = new CitasControler();
        public FormularioCita()
        {
            InitializeComponent();
            CargarCitasEnDataGridView();
        }
        private void CargarCitasEnDataGridView()
        {
            // Configuración del DataGridView
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Rows.Clear();
            dgvCitas.Columns.Clear(); // Limpia las columnas también
            dgvCitas.AllowUserToAddRows = false; // Evita la fila en blanco al final

            // Obtiene la lista de citas desde el controlador
            List<CitasModelo> listaCitas = citasController.ObtenerCitas();

            // Agrega las columnas al DataGridView
            dgvCitas.Columns.Add("idCita", "ID Cita");
            dgvCitas.Columns.Add("fecha", "Fecha");
            dgvCitas.Columns.Add("hora", "Hora");
            dgvCitas.Columns.Add("tipoCita", "Tipo de Cita");
            dgvCitas.Columns.Add("doctor", "Doctor");
            dgvCitas.Columns.Add("especialidad", "Especialidad");
            dgvCitas.Columns.Add("paciente", "Paciente");

            // Oculta la columna "ID Cita" si no es necesaria mostrarla
            dgvCitas.Columns["idCita"].Visible = false;

            // Llena el DataGridView con los datos de las citas
            foreach (CitasModelo cita in listaCitas)
            {
                dgvCitas.Rows.Add(cita.IdCita, cita.Fecha.ToShortDateString(), cita.Hora.ToString(),
                                  cita.TipoCita, cita.Doctor, cita.Especialidad, cita.Paciente);
            }
        }

        private void Limpiar()
        {
            txtIDCita.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvCitas.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado.
                int usuarioId = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["idCita"].Value);

                // Crear un objeto usuarioModel con los datos modificados.
                CitasModelo CitaReprogramada = new CitasModelo
                {
                    IdCita = usuarioId,
                    Fecha = dtpFecha.Value,
                
                };

                //Verificar si algún campo está vacío)
                if (txtIDCita.Text == string.Empty)
                {
                    MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener la operación si hay campos vacíos
                }

                // Llamar al método del controlador para actualizar el usuario.
                bool cita = citasController.ReprogramarFechaCita(CitaReprogramada);
                if (!cita) {
                    MessageBox.Show("Ocurrio un error al actualizar la hora de la cita", "Errpr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Limpiar();

                // Mostrar un mensaje de "Cambios guardados exitosamente".
                MessageBox.Show("Cambios guardados exitosamente, se notifico al paciente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la lista de usuarios en el DataGridView después de la edición.
                CargarCitasEnDataGridView();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvCitas.SelectedRows.Count > 0)
            {
                // Obtener el ID del proveedor seleccionado.
                int idCita = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["idCita"].Value);

                // Mostrar un cuadro de diálogo de confirmación antes de eliminar el proveedor.
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método del controlador para eliminar el proveedor.
                    bool cita = citasController.CancelarCita(idCita);

                    // Mostrar un mensaje de "Proveedor eliminado exitosamente".
                    MessageBox.Show("Cita Cancelada, se notificara al paciente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la lista de proveedores en el DataGridView después de la eliminación.
                    CargarCitasEnDataGridView();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvCitas.SelectedRows.Count > 0)
            {
                // Obtener el usuario seleccionado.
                DataGridViewRow filaSeleccionada = dgvCitas.SelectedRows[0];
                // Obtener los datos del usuario desde las celdas del DataGridView.
                int idCita = Convert.ToInt32(filaSeleccionada.Cells["idCita"].Value);
                DateTime NombreUsuario = Convert.ToDateTime(filaSeleccionada.Cells["fecha"].Value);

                // Cargar los datos del usuario en los TextBox para edición.
                txtIDCita.Text = idCita.ToString();
                dtpFecha.Value = NombreUsuario;
               
            }
        }
    }
}
