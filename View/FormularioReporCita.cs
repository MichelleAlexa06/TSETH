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
    public partial class FormularioReporCita : Form
    {
        private ReportController reportController = new ReportController();
        private ExpedienteController expedienteController = new ExpedienteController();
        public FormularioReporCita()
        {
            InitializeComponent();
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void FormularioProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


        }

        private void CargarCitasEnDataGridView()
        {
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Validación de fechas: Verifica que la fecha de inicio no sea mayor que la fecha final.
            if (dtpInicio.Value > dtpFinal.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si la validación falla.
            }

            // Formatea las fechas al formato "yyyy-MM-dd" para enviarlas a MySQL.
            string inicio = dtpInicio.Value.ToString("yyyy-MM-dd");
            string fin = dtpFinal.Value.ToString("yyyy-MM-dd");

            // Limpia el DataGridView antes de cargar los datos.
            dgvProductos.Rows.Clear();
            dgvProductos.Columns.Clear(); // Limpia las columnas también

            // Evitar que se agregue automáticamente una fila en blanco al final.
            dgvProductos.AllowUserToAddRows = false;

            // Llama al método para obtener las citas a través de la instancia del controlador.
            List<CitaReport> listaCitas = reportController.ObtenerCitasPorPaciente(inicio, fin);

            // Agrega las columnas al DataGridView.
            dgvProductos.Columns.Add("IdCita", "ID Cita");
            dgvProductos.Columns.Add("NombrePaciente", "Nombre del Paciente");
            dgvProductos.Columns.Add("FechaCita", "Fecha de la Cita");
            dgvProductos.Columns.Add("HoraCita", "Hora de la Cita");
            dgvProductos.Columns.Add("NombreDoctor", "Nombre del Doctor");
            dgvProductos.Columns.Add("TipoCita", "Tipo de Cita");

            // Puedes ocultar la columna "ID Cita" si lo prefieres.
            dgvProductos.Columns["IdCita"].Visible = false; // Ejemplo de ocultar la columna ID

            // Agrega las filas al DataGridView.
            foreach (CitaReport cita in listaCitas)
            {
                dgvProductos.Rows.Add(
                    cita.IdCita,
                    cita.NombrePaciente,
                    cita.FechaCita.ToString("dd/MM/yyyy"), // Formatea la fecha al estilo "dd/MM/yyyy"
                    cita.HoraCita.ToString(@"hh\:mm"), // Formatea la hora en formato "hh:mm"
                    cita.NombreDoctor,
                    cita.TipoCita
                );
            }
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            CargarCitasEnDataGridView();
            btnExportar.Enabled = true;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                // Crea una nueva hoja de trabajo.
                var worksheet = workbook.Worksheets.Add("ReporteCitas");

                // Agrega los encabezados al archivo Excel.
                for (int i = 0; i < dgvProductos.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dgvProductos.Columns[i].HeaderText;
                }

                // Agrega los datos de las filas al archivo Excel.
                for (int i = 0; i < dgvProductos.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvProductos.Columns.Count; j++)
                    {
                        if (dgvProductos.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dgvProductos.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                // Guarda el archivo en una ubicación seleccionada por el usuario.
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar Reporte de Citas";
                saveFileDialog.FileName = "ReporteCitas" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados exitosamente", "Exportación Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
