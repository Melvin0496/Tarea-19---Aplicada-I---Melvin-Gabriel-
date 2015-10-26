using System;
using System.Collections;
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
    public partial class RegistrarPelicula : Form
    {
        public RegistrarPelicula()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            TitulotextBox.Clear();
            DescripcionrichTextBox.Clear();
            AnotextBox.Clear();
            CalificaciontextBox.Clear();
            IMDBtextBox.Clear();
            CategoriaIdtextBox.Clear();
            ActoreslistBox.Items.Clear();
            GeneroslistBox.Items.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Peliculas p = new Peliculas();
            if (PeliculaIdtextBox.TextLength == 0)
            {

                

                p.Titulo = TitulotextBox.Text;
                p.Descripcion = DescripcionrichTextBox.Text;
                p.Ano = Convert.ToInt32(AnotextBox.Text);
                p.Calificacion = Convert.ToInt32(CalificaciontextBox.Text);
                p.IMDB = Convert.ToInt32(IMDBtextBox.Text);
                p.CategoriaId = Convert.ToInt32(CategoriaIdtextBox.Text);
                p.Imagen = Ruta;
                p.Video = ruta;
                p.Estudio = EstudiocomboBox.Text;
                
                for (int x = 0; x < ActoreslistBox.Items.Count; x++)
                {
                    Actores actores = new Actores();
                    int id = (int)actores.GetId(ActoreslistBox.Items[x].ToString()).Rows[0]["ActorId"];

                    p.AgregarActores(id,"");

                }

                for(int y = 0; y < GeneroslistBox.Items.Count; y++)
                {
                    Generos generos = new Generos();

                    int idGenero = (int)generos.GetIdGenero(GeneroslistBox.Items[y].ToString()).Rows[0]["GeneroId"];

                    p.AgregarGeneros(idGenero,"");
                }

                if (p.Insertar())
                {
                    MessageBox.Show("Pelicula guardada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }

                
            }
            else
            {

                p.PeliculaId = Convert.ToInt32(PeliculaIdtextBox.Text);
                p.Titulo = TitulotextBox.Text;
                p.Descripcion = DescripcionrichTextBox.Text;
                p.Ano = Convert.ToInt32(AnotextBox.Text);
                p.Calificacion = Convert.ToInt32(CalificaciontextBox.Text);
                p.IMDB = Convert.ToInt32(IMDBtextBox.Text);
                p.Estudio = EstudiocomboBox.Text;
                p.Editar();
                Limpiar();
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Peliculas pelicula = new Peliculas();
            

            pelicula.PeliculaId = Convert.ToInt32(PeliculaIdtextBox.Text); 
            if(pelicula.PeliculaId > 0)
            {
                pelicula.Eliminar();
            }
        }

        private void RegistrarPelicula_Load(object sender, EventArgs e)
        {
            Generos generos = new Generos();
            Actores actores = new Actores();
            Estudios estudios = new Estudios();

            GenerocomboBox.DataSource = generos.Listado(" GeneroId ,Descripcion","1=1");
            GenerocomboBox.DisplayMember = "Descripcion";

            ActorcomboBox.DataSource = actores.Listado(" ActorId, Nombre","1=1");
            ActorcomboBox.DisplayMember = "Nombre";

            EstudiocomboBox.DataSource = estudios.Listado(" EstudiosId, Nombre","1=1");
            EstudiocomboBox.DisplayMember = "Nombre";

        }

        private void PeliculaIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TitulotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalificaciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void IMDBtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CategoriaIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DescripcionrichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Examinarbutton_Click(object sender, EventArgs e)
        {
            ImagenesopenFileDialog.ShowDialog();
            

        }
        string Ruta = "";
        private void ImagenesopenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            ImagenespictureBox.ImageLocation = ImagenesopenFileDialog.FileName;
            Ruta = ImagenesopenFileDialog.FileName;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peliculas pelicula = new Peliculas();

            int id = Convert.ToInt32(PeliculaIdtextBox.Text);
            pelicula.Buscar(id);
            TitulotextBox.Text = pelicula.Consultar(id).Rows[0]["Titulo"].ToString();
            DescripcionrichTextBox.Text = pelicula.Consultar(id).Rows[0]["Descripcion"].ToString();
            AnotextBox.Text = pelicula.Consultar(id).Rows[0]["Ano"].ToString();
            CalificaciontextBox.Text = pelicula.Consultar(id).Rows[0]["Calificacion"].ToString();
            IMDBtextBox.Text = pelicula.Consultar(id).Rows[0]["IMDB"].ToString();
            CategoriaIdtextBox.Text = pelicula.Consultar(id).Rows[0]["Categoria"].ToString();
            ImagenespictureBox.ImageLocation = pelicula.Consultar(id).Rows[0]["Imagen"].ToString();
            Reproductor.URL = pelicula.Consultar(id).Rows[0]["Video"].ToString();

            foreach(var actor in pelicula.Actor)
            {
                ActoreslistBox.Items.Add(actor.Nombre);
            }
            foreach (var genero in pelicula.Genero)
            {
                GeneroslistBox.Items.Add(genero.Descripcion);
            }

            
            

        }

      

        string ruta;
        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.FileName = "Eliga una pelicula";
            op.Filter = "Video|*.mp4;*.avi ";
            op.InitialDirectory = @"C:\Users\Junior Gabriel\Desktop";
           

            if(op.ShowDialog() == DialogResult.OK)
            {
                ruta = op.FileName;
                Reproductor.URL = ruta;
            }
           




        }

        private void AgregarActoresbutton_Click(object sender, EventArgs e)
        {
            ActoreslistBox.Items.Add(ActorcomboBox.Text);
        }

        private void AgregarGenerosbutton_Click(object sender, EventArgs e)
        {
            GeneroslistBox.Items.Add(GenerocomboBox.Text);
        }
    }
}
