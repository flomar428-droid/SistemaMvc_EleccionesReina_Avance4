namespace SistemaMvc_EleccionesReina
{
    partial class FrmVotacionReina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVotacionReina));
            label1 = new Label();
            labelMatricula = new Label();
            textMatricula = new TextBox();
            btnBuscar = new Button();
            btnRegistrarEstudiante = new Button();
            btnVotar = new Button();
            btnVolver = new Button();
            pictureBox2 = new PictureBox();
            dgvCandidatas2 = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatas2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(627, 33);
            label1.Name = "label1";
            label1.Size = new Size(331, 50);
            label1.TabIndex = 1;
            label1.Text = "VOTACION REINA";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelMatricula.Location = new Point(116, 122);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(296, 38);
            labelMatricula.TabIndex = 2;
            labelMatricula.Text = "Matricula estudiante:";
            // 
            // textMatricula
            // 
            textMatricula.Location = new Point(418, 126);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(374, 35);
            textMatricula.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.Location = new Point(827, 122);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(131, 48);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.BackColor = SystemColors.Highlight;
            btnRegistrarEstudiante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarEstudiante.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarEstudiante.Location = new Point(972, 122);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(307, 48);
            btnRegistrarEstudiante.TabIndex = 5;
            btnRegistrarEstudiante.Text = "Registrar Estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = false;
            btnRegistrarEstudiante.Click += btnRegistrarEstudiante_Click;
            // 
            // btnVotar
            // 
            btnVotar.BackColor = SystemColors.MenuHighlight;
            btnVotar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVotar.ForeColor = SystemColors.ButtonHighlight;
            btnVotar.Location = new Point(1340, 586);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(157, 60);
            btnVotar.TabIndex = 7;
            btnVotar.Text = "VOTAR";
            btnVotar.UseVisualStyleBackColor = false;
            btnVotar.Click += btnVotar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(42, 39);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(49, 46);
            btnVolver.TabIndex = 21;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1319, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 227);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // dgvCandidatas2
            // 
            dgvCandidatas2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidatas2.Location = new Point(116, 247);
            dgvCandidatas2.Name = "dgvCandidatas2";
            dgvCandidatas2.RowHeadersWidth = 72;
            dgvCandidatas2.Size = new Size(1163, 692);
            dgvCandidatas2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(587, 193);
            label2.Name = "label2";
            label2.Size = new Size(399, 38);
            label2.TabIndex = 26;
            label2.Text = "Seleccione candidata a votar:";
            // 
            // FrmVotacionReina
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 978);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(dgvCandidatas2);
            Controls.Add(btnVolver);
            Controls.Add(btnVotar);
            Controls.Add(btnRegistrarEstudiante);
            Controls.Add(btnBuscar);
            Controls.Add(textMatricula);
            Controls.Add(labelMatricula);
            Controls.Add(label1);
            Name = "FrmVotacionReina";
            Text = "FrmVotacionReina";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatas2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelMatricula;
        private TextBox textMatricula;
        private Button btnBuscar;
        private Button btnRegistrarEstudiante;
        private Button btnVotar;
        private Button btnVolver;
        private PictureBox pictureBox2;
        private DataGridView dgvCandidatas2;
        private Label label2;
    }
}