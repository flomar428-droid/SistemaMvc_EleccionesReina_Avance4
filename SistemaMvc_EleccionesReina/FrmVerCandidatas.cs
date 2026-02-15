using SistemaEleccionReina.Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace SistemaMvc_EleccionesReina
{
    public partial class FrmVerCandidatas : Form
    {
        public FrmVerCandidatas()
        {
            InitializeComponent();
            this.Load += FrmVerCandidatas_Load;
            this.dgvCandidatas.SelectionChanged += dgvCandidatas_SelectionChanged;
        }

        private void FrmVerCandidatas_Load(object sender, EventArgs e)
        {
            dgvCandidatas.AutoGenerateColumns = true;

            try
            {
                CandidataRepositorio repo = new CandidataRepositorio();
                var lista = repo.ObtenerTodas();

                dgvCandidatas.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvCandidatas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCandidatas.CurrentRow == null)
                return;

            string nombreArchivo = dgvCandidatas.CurrentRow.Cells["FotoPrincipal"].Value?.ToString();

            if (!string.IsNullOrEmpty(nombreArchivo))
            {
                string ruta = Path.Combine(
                  AppDomain.CurrentDomain.BaseDirectory,
                  "Fotos",
                  nombreArchivo
                );


                if (File.Exists(ruta))
                {
                    pictureBoxVoto.Image = Image.FromFile(ruta);
                }
                else
                {
                    pictureBoxVoto.Image = null;
                }
            }
        }
        /*private void dgvCandidatas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCandidatas.CurrentRow == null)
                return;

            string nombreArchivo = dgvCandidatas.CurrentRow.Cells["FotoPrincipal"].Value?.ToString();

            MessageBox.Show("Nombre BD: " + nombreArchivo);

            string ruta = Path.Combine(Application.StartupPath, "Fotos", nombreArchivo);

            MessageBox.Show("Ruta completa: " + ruta);

            if (File.Exists(ruta))
            {
                MessageBox.Show("SI existe el archivo");
                pictureBox2.Image = Image.FromFile(ruta);
            }
            else
            {
                MessageBox.Show("NO existe el archivo");
            }
        }*/

    }
}
