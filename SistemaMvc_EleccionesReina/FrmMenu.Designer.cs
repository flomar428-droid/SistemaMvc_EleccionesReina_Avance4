namespace SistemaMvc_EleccionesReina
{
    partial class FrmMenu
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
            btnInscripcion = new Button();
            btnVerCandidatas = new Button();
            button1 = new Button();
            btnVotar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = SystemColors.GradientActiveCaption;
            btnInscripcion.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscripcion.Location = new Point(120, 228);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(522, 172);
            btnInscripcion.TabIndex = 0;
            btnInscripcion.Text = "Inscribir Candidata";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // btnVerCandidatas
            // 
            btnVerCandidatas.BackColor = SystemColors.GradientActiveCaption;
            btnVerCandidatas.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerCandidatas.Location = new Point(120, 427);
            btnVerCandidatas.Name = "btnVerCandidatas";
            btnVerCandidatas.Size = new Size(522, 172);
            btnVerCandidatas.TabIndex = 1;
            btnVerCandidatas.Text = "Ver Candidatas";
            btnVerCandidatas.UseVisualStyleBackColor = false;
            btnVerCandidatas.Click += btnVerCandidatas_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(668, 427);
            button1.Name = "button1";
            button1.Size = new Size(522, 172);
            button1.TabIndex = 3;
            button1.Text = "Ver Resultados";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnVotar
            // 
            btnVotar.BackColor = SystemColors.GradientActiveCaption;
            btnVotar.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVotar.Location = new Point(668, 228);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(522, 172);
            btnVotar.TabIndex = 2;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = false;
            btnVotar.Click += btnVotar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.1428585F, FontStyle.Bold);
            label1.Location = new Point(342, 103);
            label1.Name = "label1";
            label1.Size = new Size(657, 59);
            label1.TabIndex = 4;
            label1.Text = "ELECCION DE REINA FACULTAD";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 761);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnVotar);
            Controls.Add(btnVerCandidatas);
            Controls.Add(btnInscripcion);
            Name = "FrmMenu";
            Text = "FrmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscripcion;
        private Button btnVerCandidatas;
        private Button button1;
        private Button btnVotar;
        private Label label1;
    }
}