namespace TuSaludEnTusHuesos.View
{
    partial class FormularioExpediente2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioExpediente2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregarCliente = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            cbbExpAsignado = new ComboBox();
            label6 = new Label();
            txtTratamiento = new Guna.UI2.WinForms.Guna2TextBox();
            txtDiagnostico = new Guna.UI2.WinForms.Guna2TextBox();
            txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            txtSintomas = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 123);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 0;
            label1.Text = "Expediente Asignado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 225);
            label2.Name = "label2";
            label2.Size = new Size(187, 24);
            label2.TabIndex = 1;
            label2.Text = "Motivo Consulta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(555, 71);
            label3.Name = "label3";
            label3.Size = new Size(106, 24);
            label3.TabIndex = 2;
            label3.Text = "Sintomas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(86, 399);
            label4.Name = "label4";
            label4.Size = new Size(146, 24);
            label4.TabIndex = 3;
            label4.Text = "Tratamiento";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregarCliente.Location = new Point(37, 26);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(129, 49);
            btnAgregarCliente.TabIndex = 8;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(192, 192, 255);
            btnLimpiar.Location = new Point(256, 26);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 49);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarCliente);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Location = new Point(292, 582);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 107);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(366, 9);
            label5.Name = "label5";
            label5.Size = new Size(240, 44);
            label5.TabIndex = 12;
            label5.Text = "Expediente";
            // 
            // cbbExpAsignado
            // 
            cbbExpAsignado.FormattingEnabled = true;
            cbbExpAsignado.Location = new Point(86, 161);
            cbbExpAsignado.Name = "cbbExpAsignado";
            cbbExpAsignado.Size = new Size(308, 28);
            cbbExpAsignado.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(555, 225);
            label6.Name = "label6";
            label6.Size = new Size(137, 24);
            label6.TabIndex = 18;
            label6.Text = "Diagnostico";
            // 
            // txtTratamiento
            // 
            txtTratamiento.CustomizableEdges = customizableEdges1;
            txtTratamiento.DefaultText = "";
            txtTratamiento.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTratamiento.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTratamiento.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTratamiento.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTratamiento.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTratamiento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTratamiento.ForeColor = Color.Gray;
            txtTratamiento.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTratamiento.Location = new Point(86, 426);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.PasswordChar = '\0';
            txtTratamiento.PlaceholderText = "";
            txtTratamiento.SelectedText = "";
            txtTratamiento.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTratamiento.Size = new Size(860, 112);
            txtTratamiento.TabIndex = 19;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.CustomizableEdges = customizableEdges3;
            txtDiagnostico.DefaultText = "";
            txtDiagnostico.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDiagnostico.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDiagnostico.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDiagnostico.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDiagnostico.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDiagnostico.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiagnostico.ForeColor = Color.Gray;
            txtDiagnostico.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDiagnostico.Location = new Point(555, 266);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.PasswordChar = '\0';
            txtDiagnostico.PlaceholderText = "";
            txtDiagnostico.SelectedText = "";
            txtDiagnostico.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDiagnostico.Size = new Size(391, 101);
            txtDiagnostico.TabIndex = 20;
            // 
            // txtMotivo
            // 
            txtMotivo.CustomizableEdges = customizableEdges5;
            txtMotivo.DefaultText = "";
            txtMotivo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMotivo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMotivo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMotivo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMotivo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMotivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMotivo.ForeColor = Color.Gray;
            txtMotivo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMotivo.Location = new Point(86, 266);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PasswordChar = '\0';
            txtMotivo.PlaceholderText = "";
            txtMotivo.SelectedText = "";
            txtMotivo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMotivo.Size = new Size(391, 101);
            txtMotivo.TabIndex = 21;
            // 
            // txtSintomas
            // 
            txtSintomas.CustomizableEdges = customizableEdges7;
            txtSintomas.DefaultText = "";
            txtSintomas.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSintomas.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSintomas.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSintomas.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSintomas.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSintomas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSintomas.ForeColor = Color.Gray;
            txtSintomas.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSintomas.Location = new Point(555, 108);
            txtSintomas.Multiline = true;
            txtSintomas.Name = "txtSintomas";
            txtSintomas.PasswordChar = '\0';
            txtSintomas.PlaceholderText = "";
            txtSintomas.SelectedText = "";
            txtSintomas.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSintomas.Size = new Size(391, 101);
            txtSintomas.TabIndex = 22;
            // 
            // FormularioExpediente2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 712);
            Controls.Add(txtSintomas);
            Controls.Add(txtMotivo);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtTratamiento);
            Controls.Add(label6);
            Controls.Add(cbbExpAsignado);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioExpediente2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioExpedienteDoc";
            Load += FormularioClientes_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregarCliente;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtEmpresa;
        private ComboBox cbbExpAsignado;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtTratamiento;
        private Guna.UI2.WinForms.Guna2TextBox txtDiagnostico;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private Guna.UI2.WinForms.Guna2TextBox txtSintomas;
    }
}