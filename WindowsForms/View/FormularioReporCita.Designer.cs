namespace TuSaludEnTusHuesos.View
{
    partial class FormularioReporCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioReporCita));
            btnExportar = new Guna.UI2.WinForms.Guna2Button();
            dtpFinal = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            dgvProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            label5 = new Label();
            btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnExportar
            // 
            btnExportar.CustomizableEdges = customizableEdges1;
            btnExportar.DisabledState.BorderColor = Color.DarkGray;
            btnExportar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExportar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExportar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExportar.Enabled = false;
            btnExportar.FillColor = Color.LawnGreen;
            btnExportar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportar.ForeColor = Color.Black;
            btnExportar.Location = new Point(791, 107);
            btnExportar.Name = "btnExportar";
            btnExportar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExportar.Size = new Size(178, 36);
            btnExportar.TabIndex = 50;
            btnExportar.Text = "Exportar";
            btnExportar.Click += btnExportar_Click;
            // 
            // dtpFinal
            // 
            dtpFinal.Format = DateTimePickerFormat.Short;
            dtpFinal.Location = new Point(249, 107);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(139, 27);
            dtpFinal.TabIndex = 49;
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(22, 107);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(139, 27);
            dtpInicio.TabIndex = 48;
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeight = 25;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.GridColor = Color.FromArgb(231, 229, 255);
            dgvProductos.Location = new Point(12, 203);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(968, 449);
            dgvProductos.TabIndex = 46;
            dgvProductos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvProductos.ThemeStyle.BackColor = Color.White;
            dgvProductos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvProductos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvProductos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProductos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProductos.ThemeStyle.HeaderStyle.Height = 25;
            dgvProductos.ThemeStyle.ReadOnly = false;
            dgvProductos.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvProductos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProductos.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvProductos.ThemeStyle.RowsStyle.Height = 29;
            dgvProductos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvProductos.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(295, 9);
            label5.Name = "label5";
            label5.Size = new Size(351, 44);
            label5.TabIndex = 45;
            label5.Text = "Reporte de Citas";
            // 
            // btnAgregar
            // 
            btnAgregar.CustomizableEdges = customizableEdges3;
            btnAgregar.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(537, 105);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregar.Size = new Size(178, 36);
            btnAgregar.TabIndex = 44;
            btnAgregar.Text = "Consultar";
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 79);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 43;
            label4.Text = "Inicio";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(249, 79);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(42, 24);
            lblPrecio.TabIndex = 42;
            lblPrecio.Text = "Fin";
            // 
            // FormularioReporCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 663);
            Controls.Add(btnExportar);
            Controls.Add(dtpFinal);
            Controls.Add(dtpInicio);
            Controls.Add(dgvProductos);
            Controls.Add(label5);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(lblPrecio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioReporCita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioReportCita";
            Load += FormularioProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExportar;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInicio;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductos;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Label label4;
        private Label lblPrecio;
    }
}