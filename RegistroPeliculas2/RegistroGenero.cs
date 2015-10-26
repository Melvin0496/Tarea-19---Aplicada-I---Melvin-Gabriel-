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
    public partial class RegistroGenero : Form
    {
        ErrorProvider miError;
        public RegistroGenero()
        {
            InitializeComponent();
            miError = new ErrorProvider();
        }
        public void Limpiar()
        {
            GeneroIdtextBox.Clear();
            DescripcionrichTextBox.Clear();
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Generos generos = new Generos();
            if (GeneroIdtextBox.TextLength == 0)
            {
                if (DescripcionrichTextBox.TextLength == 0)
                {
                    miError.Clear();
                    miError.SetError(DescripcionrichTextBox, "Debe completar este campo");
                }
                else
                {
                    generos.Descripcion = DescripcionrichTextBox.Text;
                    generos.Insertar();
                    MessageBox.Show("Genero Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Limpiar();
            }
            else
            {
                generos.GeneroId = Convert.ToInt32(GeneroIdtextBox.Text);
                generos.Descripcion = DescripcionrichTextBox.Text;
                generos.Editar();
                MessageBox.Show("Se Edito con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Generos generos = new Generos();

            if (GeneroIdtextBox.TextLength > 0)
            {
                generos.GeneroId = Convert.ToInt32(GeneroIdtextBox.Text);
                if (generos.Eliminar())
                {
                    MessageBox.Show("Se Elimino el genero","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo borrar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe de Especificar el Id", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
