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
    public partial class FrmVotacionReina : Form
    {
        public FrmVotacionReina()
        {
            InitializeComponent();
            this.Load += FrmVotacionReina_Load;

            this.dgvCandidatas2.SelectionChanged += dgvCandidatas2_SelectionChanged;
        }

        private void FrmVotacionReina_Load(object sender, EventArgs e)
        {
            btnVotar.Enabled = false;        // Deshabilita votar
            dgvCandidatas2.Enabled = false;   // No se pueden seleccionar candidatas
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textMatricula.Text))
            {
                MessageBox.Show("Ingrese la matrícula");
                return;
            }

            EstudianteRepositorio repo = new EstudianteRepositorio();
            var estudiante = repo.ObtenerPorMatricula(textMatricula.Text);


            if (estudiante == null)
            {
                MessageBox.Show("Estudiante no encontrado");
                btnVotar.Enabled = false;
                dgvCandidatas2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bienvenido");

                textMatricula.Enabled = false;
                btnVotar.Enabled = true;        // 🔥 Se activa votar
                dgvCandidatas2.Enabled = true;   // 🔥 Se activa selección

                CargarCandidatas(); // método que carga el DataGrid
            }
        }

        private void CargarCandidatas()
        {
            CandidataRepositorio repo = new CandidataRepositorio();
            var lista = repo.ObtenerTodas();
            dgvCandidatas2.DataSource = lista;
        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            FrmEstudiante frm = new FrmEstudiante();
            frm.ShowDialog(); // 👈 Esto bloquea FrmVotacionReina
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (dgvCandidatas2.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una candidata");
                return;
            }

            int idCandidata = Convert.ToInt32(
                dgvCandidatas2.CurrentRow.Cells["Id"].Value
            );

            // Primero buscar el estudiante por matrícula
            EstudianteRepositorio repoEst = new EstudianteRepositorio();
            var estudiante = repoEst.ObtenerPorMatricula(textMatricula.Text);

            if (estudiante == null)
            {
                MessageBox.Show("Estudiante no encontrado");
                return;
            }

            VotoRepositorio repoVoto = new VotoRepositorio();

            // 🔒 Validar si ya votó
            bool yaVoto = repoVoto.YaVoto(estudiante.Id, "Reina");

            if (yaVoto)
            {
                MessageBox.Show("Este estudiante ya votó.");
                return;
            }

            // Crear objeto voto
            Voto nuevoVoto = new Voto
            {
                IdCandidata = idCandidata,
                IdEstudiante = estudiante.Id,
                TipoVotacion = "Reina",
                Fecha = DateTime.Now
            };

            // Registrar voto
            repoVoto.RegistrarVoto(nuevoVoto);

            MessageBox.Show("Voto registrado correctamente");

            // Resetear
            textMatricula.Clear();
            textMatricula.Enabled = true;
            btnVotar.Enabled = false;
        }


        private void dgvCandidatas2_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCandidatas2.CurrentRow == null)
                return;

            string nombreArchivo = dgvCandidatas2
                .CurrentRow
                .Cells["FotoPrincipal"]
                .Value?
                .ToString();

            if (!string.IsNullOrEmpty(nombreArchivo))
            {
                string ruta = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Fotos",
                    nombreArchivo
                );

                if (File.Exists(ruta))
                {
                    pictureBox2.Image = Image.FromFile(ruta);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox2.Image = null;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
