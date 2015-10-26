using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BLL;

namespace RegistroPeliculas2
{
    public partial class RegistroPelicula : Form
    {
        public RegistroPelicula()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPelicula rp = new RegistrarPelicula();
            rp.Show();
        }

        private void filmsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarPeliculas cp = new ConsultarPeliculas();
            cp.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroGenero registroGenero = new RegistroGenero();
            registroGenero.Show();
        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroActores registroActores = new RegistroActores();
            registroActores.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegistroEstudio registroEstudio = new RegistroEstudio();
            registroEstudio.ShowDialog();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarGenero consultarGenero = new ConsultarGenero();
            consultarGenero.ShowDialog();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteForm reporte = new ReporteForm();
            ReportePelicula rpt = new ReportePelicula();
            reporte.reportecrystalReportViewer.ReportSource = rpt;
            reporte.reportecrystalReportViewer.RefreshReport();
            reporte.ShowDialog();
            
        }
    }
}
