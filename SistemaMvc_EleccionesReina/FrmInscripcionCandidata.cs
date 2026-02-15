using SistemaEleccionReina.Datos;
using SistemaEleccionReina.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace SistemaMvc_EleccionesReina
{

    public partial class FrmInscripcionCandidata : Form
    {
        private string nombreArchivoImagen = "";

        public FrmInscripcionCandidata()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                MessageBox.Show("Debe ingresar la carrera");
                txtCarrera.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPasatiempos.Text))
            {
                MessageBox.Show("Debe ingresar los pasatiempos");
                txtPasatiempos.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHabilidades.Text))
            {
                MessageBox.Show("Debe ingresar las habilidades");
                txtHabilidades.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIntereses.Text))
            {
                MessageBox.Show("Debe ingresar los intereses");
                txtIntereses.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAspiraciones.Text))
            {
                MessageBox.Show("Debe ingresar las aspiraciones");
                txtAspiraciones.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nombreArchivoImagen))
            {
                MessageBox.Show("Debe cargar una foto");
                return;
            }

            try
            {
                CandidataRepositorio repo = new CandidataRepositorio();

                Candidata nueva = new Candidata
                {
                    Nombre = txtNombre.Text,
                    Carrera = txtCarrera.Text,
                    Edad = (int)nudEdad.Value,
                    Pasatiempos = txtPasatiempos.Text,
                    Habilidades = txtHabilidades.Text,
                    Intereses = txtIntereses.Text,
                    Aspiraciones = txtAspiraciones.Text,
                    FotoPrincipal = nombreArchivoImagen
                };

                repo.Insertar(nueva);

                MessageBox.Show("Candidata registrada correctamente");

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCarrera.Clear();
            txtPasatiempos.Clear();
            txtHabilidades.Clear();
            txtIntereses.Clear();
            txtAspiraciones.Clear();
            nudEdad.Value = 18;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nombreArchivoImagen = Path.GetFileName(ofd.FileName);

                // 📌 Ruta base del ejecutable REAL
                string carpetaFotos = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Fotos"
                );

                if (!Directory.Exists(carpetaFotos))
                {
                    Directory.CreateDirectory(carpetaFotos);
                }

                string rutaDestino = Path.Combine(carpetaFotos, nombreArchivoImagen);

                File.Copy(ofd.FileName, rutaDestino, true);

                pictureBox1.Image = Image.FromFile(rutaDestino);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                MessageBox.Show("Foto cargada correctamente");
            }
        }
    }
}
