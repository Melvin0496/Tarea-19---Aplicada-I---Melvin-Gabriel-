using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BLL;

namespace RegistroPeliculas2
{
    public partial class ConsultarGenero : Form
    {
        public ConsultarGenero()
        {
            InitializeComponent();
        }

        private void BuscarGenerobutton_Click(object sender, EventArgs e)
        {
            Generos genero = new Generos();
            DataTable dt = new DataTable();
            string condicion;

            if(GeneroConsultacomboBox.SelectedIndex == 0)
            {
                if (GeneroConsultatextBox.Text.Trim().Length == 0)
                {
                    condicion = "1=1";
                }
                else
                {
                    condicion = "GeneroId = " + GeneroConsultatextBox.Text;
                }
                dt = genero.Listado("GeneroId,Descripcion", condicion);
                GeneroConsultadataGridView.DataSource = dt;
            }
            if(GeneroConsultacomboBox.SelectedIndex == 1)
            {
                if(GeneroConsultatextBox.Text.Trim().Length == 1)
                {
                    condicion = "2=2";
                }
                else
                {
                    condicion = "Descripcion = " + GeneroConsultatextBox.Text + "";
                }
                dt = genero.Listado("GeneroId,Descripcion", condicion);
                GeneroConsultadataGridView.DataSource = dt;
            }

        }
    }
}
