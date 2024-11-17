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
    public partial class FormularioReporDoctor : Form
    {
        private ReportController reportController = new ReportController();
        private ExpedienteController expedienteController = new ExpedienteController();
        public FormularioReporDoctor()
        {
            InitializeComponent();

        }
        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarUsuariosEnComboBox();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbbDoctor.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la operación si hay campos vacíos
            }
            CargarExpedienteEnDataGridView();
            btnExportar.Enabled = true;
        }
        protected virtual void OnProductoAgregado(EventArgs e)
        {

        }
        private void CargarUsuariosEnComboBox()
        {
            // Llenar el ComboBox de Doctor
            cbbDoctor.DataSource = expedienteController.ObtenerDatosDoctor();
            cbbDoctor.DisplayMember = "NombreCompleto";  // Mostrar Nombre Completo
            cbbDoctor.ValueMember = "id";  // Usar idDoctor como valor
        }


        private void CargarExpedienteEnDataGridView()
        {
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int doctor = (int)cbbDoctor.SelectedValue;

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

            // Llama al método para obtener los expedientes a través de la instancia del controlador.
            List<ExpedienteReport> listaReporte = reportController.ObtenerExpedientesPorDoctor(doctor, inicio, fin);

            // Agrega las columnas al DataGridView.
            dgvProductos.Columns.Add("IdExpediente", "ID Expediente");
            dgvProductos.Columns.Add("NombrePaciente", "Nombre del Paciente");
            dgvProductos.Columns.Add("FechaCreacion", "Fecha de Creación");
            dgvProductos.Columns.Add("EstadoCivil", "Estado Civil");
            dgvProductos.Columns.Add("GrupoSanguineo", "Grupo Sanguíneo");
            dgvProductos.Columns.Add("FactorRH", "Factor RH");
            dgvProductos.Columns.Add("MotivoConsulta", "Motivo de Consulta");

            // Puedes ocultar columnas si lo prefieres.
            dgvProductos.Columns["IdExpediente"].Visible = false; // Ejemplo de ocultar la columna ID

            // Agrega las filas al DataGridView.
            foreach (ExpedienteReport expediente in listaReporte)
            {
                dgvProductos.Rows.Add(
                    expediente.IdExpediente,
                    expediente.NombrePaciente,
                    expediente.FechaCreacion.ToString("dd/MM/yyyy"),
                    expediente.EstadoCivil,
                    expediente.GrupoSanguineo,
                    expediente.FactorRH,
                    expediente.MotivoConsulta
                );
            }
        }



        private int productoSeleccionadoId = -1; // Variable para almacenar el ID del producto seleccionado
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                // Crea una nueva hoja de trabajo.
                var worksheet = workbook.Worksheets.Add("ReporteExpedientes");

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
                saveFileDialog.Title = "Guardar Reporte de Expedientes";
                saveFileDialog.FileName = "ReporteExpedientes" + DateTime.Now.ToString("dd-MM-yyyy") +".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados exitosamente", "Exportación Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
