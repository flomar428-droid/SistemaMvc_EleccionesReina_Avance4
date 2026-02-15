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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el menú

            FrmInscripcionCandidata frm = new FrmInscripcionCandidata();
            frm.ShowDialog(); // Espera hasta que se cierre

            this.Show(); // Cuando se cierre inscripción, vuelve el menú
        }

        private void btnVerCandidatas_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmVerCandidatas frm = new FrmVerCandidatas();
            frm.ShowDialog();

            this.Show();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta menú

            FrmVotacionReina frm = new FrmVotacionReina();
            frm.ShowDialog(); // Espera que se cierre

            this.Show(); // Vuelve el menú
        }


    }
}
