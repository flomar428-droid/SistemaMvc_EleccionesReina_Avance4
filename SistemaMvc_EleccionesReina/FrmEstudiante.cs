using SistemaEleccionReina.Datos;
using SistemaEleccionReina.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaMvc_EleccionesReina
{
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEstudiante.Text) ||
        string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            EstudianteRepositorio repo = new EstudianteRepositorio();

            Estudiante nuevo = new Estudiante
            {
                Nombre = txtNombreEstudiante.Text,
                Matricula = txtMatricula.Text
            };

            repo.Insertar(nuevo);

            MessageBox.Show("Estudiante registrado correctamente");
            this.Close();
        }
    }
}
