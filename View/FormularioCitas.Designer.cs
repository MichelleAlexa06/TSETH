namespace TuSaludEnTusHuesos.View
{
    partial class FormularioCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCita));
            txtIDCita = new Guna.UI2.WinForms.Guna2TextBox();
            dgvCitas = new Guna.UI2.WinForms.Guna2DataGridView();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnReprograma = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIDCita
            // 
            txtIDCita.CustomizableEdges = customizableEdges1;
            txtIDCita.DefaultText = "";
            txtIDCita.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtIDCita.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtIDCita.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtIDCita.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtIDCita.Enabled = false;
            txtIDCita.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIDCita.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDCita.ForeColor = Color.Gray;
            txtIDCita.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIDCita.Location = new Point(295, 525);
            txtIDCita.Name = "txtIDCita";
            txtIDCita.PasswordChar = '\0';
            txtIDCita.PlaceholderText = "";
            txtIDCita.SelectedText = "";
            txtIDCita.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtIDCita.Size = new Size(130, 45);
            txtIDCita.TabIndex = 35;
            // 
            // dgvCitas
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCitas.ColumnHeadersHeight = 50;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCitas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCitas.GridColor = Color.FromArgb(231, 229, 255);
            dgvCitas.Location = new Point(32, 100);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.RowTemplate.Height = 29;
            dgvCitas.Size = new Size(650, 376);
            dgvCitas.TabIndex = 34;
            dgvCitas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCitas.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCitas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCitas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCitas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCitas.ThemeStyle.BackColor = Color.White;
            dgvCitas.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCitas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCitas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCitas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCitas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCitas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCitas.ThemeStyle.HeaderStyle.Height = 50;
            dgvCitas.ThemeStyle.ReadOnly = false;
            dgvCitas.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCitas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCitas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCitas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCitas.ThemeStyle.RowsStyle.Height = 29;
            dgvCitas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCitas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(270, 9);
            label5.Name = "label5";
            label5.Size = new Size(365, 42);
            label5.TabIndex = 33;
            label5.Text = "CITAS PROXIMAS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnReprograma);
            groupBox1.Location = new Point(710, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 237);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(37, 152);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 49);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnEliminar_Click;
            // 
            // btnReprograma
            // 
            btnReprograma.BackColor = Color.FromArgb(192, 255, 192);
            btnReprograma.Location = new Point(37, 46);
            btnReprograma.Name = "btnReprograma";
            btnReprograma.Size = new Size(129, 49);
            btnReprograma.TabIndex = 8;
            btnReprograma.Text = "Reprogramar";
            btnReprograma.UseVisualStyleBackColor = false;
            btnReprograma.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(199, 590);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 29;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(199, 525);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 28;
            label1.Text = "IDCita";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(295, 590);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(130, 27);
            dtpFecha.TabIndex = 36;
            // 
            // FormularioCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 660);
            Controls.Add(dtpFecha);
            Controls.Add(txtIDCita);
            Controls.Add(dgvCitas);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormularioCita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioCitas";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtPrecop;
        private Guna.UI2.WinForms.Guna2TextBox txtIDCita;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCitas;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnReprograma;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFecha;
    }
}