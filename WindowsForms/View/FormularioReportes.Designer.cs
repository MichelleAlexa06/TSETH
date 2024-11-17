namespace TuSaludEnTusHuesos.View
{
    partial class FormularioReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioReportes));
            groupBox1 = new GroupBox();
            btnModificar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(139, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 100);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 255, 192);
            btnModificar.Location = new Point(276, 26);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(207, 49);
            btnModificar.TabIndex = 10;
            btnModificar.Text = " Reporte de Citas ";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.Location = new Point(37, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(213, 49);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Reporte de Expedientes por Doctor";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 32);
            label5.Name = "label5";
            label5.Size = new Size(708, 44);
            label5.TabIndex = 22;
            label5.Text = "Seleccione el reporte a visualizar";
            // 
            // FormularioReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 231);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioReportes";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label5;
    }
}