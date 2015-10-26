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
    public partial class RegistroEstudio : Form
    {
        public RegistroEstudio()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            EstudioIdtextBox.Clear();
            NombreEstudiotextBox.Clear();
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Estudios estudios = new Estudios();

            estudios.EstudioId = Convert.ToInt32(EstudioIdtextBox.Text);
            if (estudios.Eliminar())
            {
                MessageBox.Show("Se borro el estudio","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede borrar el estudio","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudios estudios = new Estudios();

         
            if(EstudioIdtextBox.TextLength == 0)
            {
                estudios.Nombre = NombreEstudiotextBox.Text;
                if (estudios.Insertar())
                {
                    MessageBox.Show("Estudio guardado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("no se guardo el estudio","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                Limpiar();
            }
            else
            {
                estudios.EstudioId = Convert.ToInt32(EstudioIdtextBox.Text);
                estudios.Nombre = NombreEstudiotextBox.Text;
                if (estudios.Editar())
                {
                    MessageBox.Show("Se edito correctamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se edito","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                Limpiar();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
