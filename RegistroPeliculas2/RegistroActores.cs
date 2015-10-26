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
    public partial class RegistroActores : Form
    {
        public RegistroActores()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            ActorIdtextBox.Clear();
            NombreActortextBox.Clear();
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            Actores actores = new Actores();

            if (ActorIdtextBox.TextLength == 0)
            {
                actores.Nombre = NombreActortextBox.Text;
                if (actores.Insertar())
                {
                    MessageBox.Show("Actores Guardados","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                Limpiar();
            }
            else
            {
                actores.ActorId = Convert.ToInt32(ActorIdtextBox.Text);
                actores.Nombre = NombreActortextBox.Text;
                if (actores.Editar())
                {
                    MessageBox.Show("Se edito corectamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                Limpiar();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Actores actores = new Actores();

            actores.ActorId = Convert.ToInt32(ActorIdtextBox.Text);

            if (actores.Eliminar())
            {
                MessageBox.Show("Actor Borrado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo borrar el actor","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Limpiar();
        }
    }
}
