namespace SistemaMvc_EleccionesReina
{
    partial class FrmEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiante));
            label1 = new Label();
            txtNombreEstudiante = new TextBox();
            txtMatricula = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btnGuardarEstudiante = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(555, 52);
            label1.Name = "label1";
            label1.Size = new Size(492, 50);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE ESTUDIANTE";
            // 
            // txtNombreEstudiante
            // 
            txtNombreEstudiante.Location = new Point(671, 210);
            txtNombreEstudiante.Name = "txtNombreEstudiante";
            txtNombreEstudiante.Size = new Size(600, 35);
            txtNombreEstudiante.TabIndex = 22;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(671, 154);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(600, 35);
            txtMatricula.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(446, 154);
            label9.Name = "label9";
            label9.Size = new Size(210, 38);
            label9.TabIndex = 20;
            label9.Text = "Matricula (DNI):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(531, 210);
            label8.Name = "label8";
            label8.Size = new Size(125, 38);
            label8.TabIndex = 19;
            label8.Text = "Nombre:";
            // 
            // btnGuardarEstudiante
            // 
            btnGuardarEstudiante.BackColor = SystemColors.Highlight;
            btnGuardarEstudiante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarEstudiante.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarEstudiante.Location = new Point(726, 300);
            btnGuardarEstudiante.Name = "btnGuardarEstudiante";
            btnGuardarEstudiante.Size = new Size(166, 47);
            btnGuardarEstudiante.TabIndex = 23;
            btnGuardarEstudiante.Text = "GUARDAR";
            btnGuardarEstudiante.UseVisualStyleBackColor = false;
            btnGuardarEstudiante.Click += btnGuardarEstudiante_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(102, 60);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(49, 46);
            btnVolver.TabIndex = 24;
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // FrmEstudiante
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 396);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardarEstudiante);
            Controls.Add(txtNombreEstudiante);
            Controls.Add(txtMatricula);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "FrmEstudiante";
            Text = "FrmEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreEstudiante;
        private TextBox txtMatricula;
        private Label label9;
        private Label label8;
        private Button btnGuardarEstudiante;
        private Button btnVolver;
    }
}