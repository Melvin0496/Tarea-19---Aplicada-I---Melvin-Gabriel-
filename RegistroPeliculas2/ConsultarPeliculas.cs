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
    
    public partial class ConsultarPeliculas : Form
    {
        ErrorProvider miError;
        public ConsultarPeliculas()
        {
            InitializeComponent();
            miError = new ErrorProvider();
            
        }

        public void Error()
        {
            miError.SetError(PeliculaIdtextBox, "Este campo debe completarse");
           
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            Peliculas pelicula = new Peliculas();
            DataTable dataTable = new DataTable();
            string condicion;

            if(PeliculaIdtextBox.Text.Length == 0)
            {
                Error();
            }
            else
            {
                if (BuscarcomboBox.SelectedIndex == 0)
                {


                    if (PeliculaIdtextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = "PeliculaId = " + PeliculaIdtextBox.Text;
                    }
                    dataTable = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId,Imagen,Video", condicion);
                    ConsultadataGridView.DataSource = dataTable;




                }
                if (BuscarcomboBox.SelectedIndex == 1)
                {
                    if (PeliculaIdtextBox.Text.Trim().Length == 1)
                    {
                        condicion = "2=2";
                    }
                    else
                    {
                        condicion = "Titulo = '" + PeliculaIdtextBox.Text + "'";
                    }
                    dataTable = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId,Imagen,Video,Genero,Actor,Estudio ", condicion);
                    ConsultadataGridView.DataSource = dataTable;

                }
                if (BuscarcomboBox.SelectedIndex == 2)
                {
                    if (PeliculaIdtextBox.Text.Trim().Length == 2)
                    {
                        condicion = "3=3";
                    }
                    else
                    {
                        condicion = "Ano =" + PeliculaIdtextBox.Text;
                    }
                    dataTable = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId,Imagen,Video,Genero,Actor,Estudio", condicion);
                    ConsultadataGridView.DataSource = dataTable;

                }
                if (BuscarcomboBox.SelectedIndex == 3)
                {
                    if (PeliculaIdtextBox.Text.Trim().Length == 3)
                    {
                        condicion = "4=4";
                    }
                    else
                    {
                        condicion = "Calificacion =" + PeliculaIdtextBox.Text;
                    }
                    dataTable = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId,Imagen,Video,Genero,Actor,Estudio", condicion);
                    ConsultadataGridView.DataSource = dataTable;
                }
                if (BuscarcomboBox.SelectedIndex == 4)
                {
                    if (PeliculaIdtextBox.Text.Trim().Length == 4)
                    {
                        condicion = "5=5";
                    }
                    else
                    {
                        condicion = "IMDB = " + PeliculaIdtextBox.Text;
                    }
                    dataTable = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMDB, CategoriaId ,Imagen,Video,Genero,Actor,Estudio ", condicion);
                    ConsultadataGridView.DataSource = dataTable;
                }
                if (BuscarcomboBox.SelectedIndex == 5)
                {
                    if (PeliculaIdtextBox.Text.Trim().Length == 5)
                    {
                        condicion = "6=6";
                    }
                    else
                    {
                        condicion = "CategoriaId" + PeliculaIdtextBox.Text;
                    }
                    dataTable = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId,Imagen,Video,Genero,Actor,Estudio ", condicion);
                    ConsultadataGridView.DataSource = dataTable;
                }
                if(BuscarcomboBox.SelectedIndex == 6)
                {
                    if(PeliculaIdtextBox.Text.Trim().Length == 6)
                    {
                        condicion = "7=7";
                    }
                    else
                    {
                        condicion = "Genero" + PeliculaIdtextBox.Text;
                    }
                    dataTable = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId,Imagen,Video,Genero,Actor,Estudio", condicion);
                    ConsultadataGridView.DataSource = dataTable;
                }
                if(BuscarcomboBox.SelectedIndex == 7)
                {
                    if(PeliculaIdtextBox.Text.Trim().Length == 7)
                    {
                        condicion = "8=8";
                    }
                    else
                    {
                        condicion = "Actor" + PeliculaIdtextBox.Text;
                    }
                    dataTable = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId,Imagen,Video,Genero,Actor,Estudio ", condicion);
                    ConsultadataGridView.DataSource = dataTable;
                }
                if(BuscarcomboBox.SelectedIndex == 8)
                {
                    if(PeliculaIdtextBox.Text.Trim().Length == 8)
                    {
                        condicion = "9=9";
                    }
                    else
                    {
                        condicion = "Estudio" + PeliculaIdtextBox.Text;
                    }
                    dataTable = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId,Imagen,Video,Genero,Actor,Estudio ", condicion);
                    ConsultadataGridView.DataSource = dataTable;
                }
            }
           
            
        }
    }
}
