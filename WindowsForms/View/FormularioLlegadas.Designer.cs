namespace TuSaludEnTusHuesos.View
{
    partial class FormularioLlegadas
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLlegadas));
            label5 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cbbCitas = new ComboBox();
            dtpHora = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            btnRegistrarLlegada = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            label2 = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(437, 44);
            label5.TabIndex = 17;
            label5.Text = "Registro de Llegadas";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(cbbCitas);
            guna2Panel1.Controls.Add(dtpHora);
            guna2Panel1.Controls.Add(dtpFecha);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(btnRegistrarLlegada);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(73, 56);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(315, 405);
            guna2Panel1.TabIndex = 20;
            // 
            // cbbCitas
            // 
            cbbCitas.FormattingEnabled = true;
            cbbCitas.Location = new Point(25, 57);
            cbbCitas.Name = "cbbCitas";
            cbbCitas.Size = new Size(250, 28);
            cbbCitas.TabIndex = 31;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(25, 245);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(250, 27);
            dtpHora.TabIndex = 30;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(25, 140);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 190);
            label1.Name = "label1";
            label1.Size = new Size(182, 24);
            label1.TabIndex = 28;
            label1.Text = "Hora de llegada";
            // 
            // btnRegistrarLlegada
            // 
            btnRegistrarLlegada.CustomizableEdges = customizableEdges1;
            btnRegistrarLlegada.DisabledState.BorderColor = Color.DarkGray;
            btnRegistrarLlegada.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegistrarLlegada.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegistrarLlegada.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegistrarLlegada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarLlegada.ForeColor = Color.White;
            btnRegistrarLlegada.Location = new Point(50, 328);
            btnRegistrarLlegada.Name = "btnRegistrarLlegada";
            btnRegistrarLlegada.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRegistrarLlegada.Size = new Size(225, 56);
            btnRegistrarLlegada.TabIndex = 26;
            btnRegistrarLlegada.Text = "Registrar llegada";
            btnRegistrarLlegada.Click += btnGenerarLicitacion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 99);
            label3.Name = "label3";
            label3.Size = new Size(190, 24);
            label3.TabIndex = 23;
            label3.Text = "Fecha de llegada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 21);
            label2.Name = "label2";
            label2.Size = new Size(54, 24);
            label2.TabIndex = 22;
            label2.Text = "Cita";
            // 
            // FormularioLlegadas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 496);
            Controls.Add(guna2Panel1);
            Controls.Add(label5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioLlegadas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioLlegadas";
            Load += FormularioLicitaciones_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarLlegada;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label1;
        private DateTimePicker dtpHora;
        private ComboBox cbbCitas;
    }
}