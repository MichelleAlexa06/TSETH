namespace TuSaludEnTusHuesos.View
{
    partial class FormularioReporDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioReporDoctor));
            label2 = new Label();
            lblPrecio = new Label();
            label4 = new Label();
            btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            dgvProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            cbbDoctor = new ComboBox();
            dtpInicio = new DateTimePicker();
            dtpFinal = new DateTimePicker();
            btnExportar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 83);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 24;
            label2.Text = "Doctor";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(526, 83);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(42, 24);
            lblPrecio.TabIndex = 26;
            lblPrecio.Text = "Fin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(361, 83);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 27;
            label4.Text = "Inicio";
            // 
            // btnAgregar
            // 
            btnAgregar.CustomizableEdges = customizableEdges1;
            btnAgregar.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(725, 83);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAgregar.Size = new Size(178, 33);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Consultar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(144, 9);
            label5.Name = "label5";
            label5.Size = new Size(721, 44);
            label5.TabIndex = 33;
            label5.Text = "Reporte de Expedientes por doctor";
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
            dgvProductos.Location = new Point(12, 202);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(968, 449);
            dgvProductos.TabIndex = 34;
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
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // cbbDoctor
            // 
            cbbDoctor.FormattingEnabled = true;
            cbbDoctor.Location = new Point(67, 110);
            cbbDoctor.Name = "cbbDoctor";
            cbbDoctor.Size = new Size(257, 28);
            cbbDoctor.TabIndex = 37;
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(361, 111);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(139, 27);
            dtpInicio.TabIndex = 38;
            // 
            // dtpFinal
            // 
            dtpFinal.Format = DateTimePickerFormat.Short;
            dtpFinal.Location = new Point(526, 111);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(139, 27);
            dtpFinal.TabIndex = 39;
            // 
            // btnExportar
            // 
            btnExportar.CustomizableEdges = customizableEdges3;
            btnExportar.DisabledState.BorderColor = Color.DarkGray;
            btnExportar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExportar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExportar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExportar.Enabled = false;
            btnExportar.FillColor = Color.LawnGreen;
            btnExportar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportar.ForeColor = Color.Black;
            btnExportar.Location = new Point(725, 136);
            btnExportar.Name = "btnExportar";
            btnExportar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExportar.Size = new Size(178, 33);
            btnExportar.TabIndex = 40;
            btnExportar.Text = "Exportar";
            btnExportar.Click += btnExportar_Click;
            // 
            // FormularioReporDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 663);
            Controls.Add(btnExportar);
            Controls.Add(dtpFinal);
            Controls.Add(dtpInicio);
            Controls.Add(cbbDoctor);
            Controls.Add(dgvProductos);
            Controls.Add(label5);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(lblPrecio);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioReporDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioReporDoctor";
            Load += FormularioProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblPrecio;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductos;
        private ComboBox cbbDoctor;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFinal;
        private Guna.UI2.WinForms.Guna2Button btnExportar;
    }
}