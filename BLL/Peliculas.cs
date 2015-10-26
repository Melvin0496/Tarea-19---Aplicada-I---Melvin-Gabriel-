using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Peliculas: ClaseMaestra
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int IMDB { get; set; }
        public int CategoriaId { get; set; }
        public string Imagen { get; set; }
        public string Video { get; set; }
        public string Estudio { get; set; }

        public List<Actores> Actor { get; set; }
        public List<Generos> Genero { get; set; }
        Actores actorVar;
        Conexion conexion;
        Generos generoVar;




        public Peliculas()
        {
            PeliculaId = 0;
            Titulo = "";
            Descripcion = "";
            Ano = 0;
            Calificacion = 0;
            IMDB = 0;
            CategoriaId = 0;
            Imagen = "";
            Video = "";
            Estudio = "";
            Actor = new List<Actores>();
            Genero = new List<Generos>();
            conexion = new Conexion();
            actorVar = new Actores();
            generoVar = new Generos();
        }
        public Peliculas(int pPeliculaId,string pTitulo,string pDescripcion,int pAno,int pCalificacion,int pIMDB,int pCategoriId,string pImage,string pVideo,string pEstudio)
        {
            PeliculaId = pPeliculaId;
            Titulo = pTitulo;
            Descripcion = pDescripcion;
            Ano = pAno;
            Calificacion = pCalificacion;
            IMDB = pIMDB;
            CategoriaId = pCategoriId;
            Imagen = pImage;
            Video = pVideo;
            Estudio = pEstudio;
           

        }
       
        public void AgregarActores(int ActorId,string Nombre)
        {
            this.Actor.Add(new Actores(ActorId,Nombre));
        }
        public void AgregarGeneros(int GeneroId,string Descripcion)
        {
            this.Genero.Add(new Generos(GeneroId,Descripcion));
        }
        
        public int GetGeneroId()
        {
            return generoVar.GeneroId = (int)conexion.ObtenerDatos("Select GeneroId from Generos").Rows[0]["GeneroId"];
        }
        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder comando = new StringBuilder();

            

           retorno = conexion.Ejecutar(string.Format("Insert into Peliculas(Titulo,Descripcion,Ano,Calificacion,IMDB,CategoriaId,Imagen,Video,Estudio) values('{0}','{1}',{2},{3},{4},{5},'{6}','{7}','{8}') ", this.Titulo,this.Descripcion,this.Ano,this.Calificacion,this.IMDB,this.CategoriaId,this.Imagen,this.Video,this.Estudio));
            if (retorno)
            {
                this.PeliculaId = (int)conexion.ObtenerDatos("Select Max(PeliculaId) as PeliculaId from Peliculas").Rows[0]["PeliculaId"];

                foreach (var actor in this.Actor)
                {
                    comando.AppendLine(string.Format("Insert into PeliculasActores(PeliculaId,ActorId) values({0},{1})", this.PeliculaId, actor.ActorId));
                }
        
                foreach(var genero in this.Genero)
                {
                    comando.AppendLine(string.Format("Insert into PeliculasGeneros(PeliculaId,GeneroId) values({0},{1})", this.PeliculaId, genero.GeneroId));
                }
                retorno = conexion.Ejecutar(comando.ToString());
            }
            return retorno;
        }


        public override bool Editar()
        {
            bool retorno = false;
            StringBuilder comando = new StringBuilder();
            Conexion conexion = new Conexion();

            retorno = conexion.Ejecutar(string.Format("update Peliculas set Titulo = '{0}',Descripcion = '{1}',Ano = '{2}', Calificacion = '{3}',IMDB = '{4}' where PeliculaId = '{5}'", Titulo, Descripcion, Ano, Calificacion, IMDB, this.PeliculaId));
            if (retorno)
            {
                conexion.Ejecutar("Delete from PeliculasActores where PeliculaId =" +this.PeliculaId);
                conexion.Ejecutar("Delete from PeliculasGeneros where PeliculaId =" +this.PeliculaId);

                foreach(var actor in this.Actor)
                {
                    comando.AppendLine(string.Format("Insert into PeliculasActores(PeliculaId,ActorId) values({0},{1});", this.PeliculaId, actor.ActorId));
                }

                foreach(var genero in this.Genero)
                {
                    comando.AppendLine(string.Format("Insert into PeliculasGeneros(PeliculaId,GeneroId) values({0},{1});", this.PeliculaId,genero.GeneroId));
                }
                retorno = conexion.Ejecutar(comando.ToString());
            }
            return retorno;

        }
       
        public override bool Eliminar()
        {
            bool retorno = false;
            Conexion conexion = new Conexion();

            retorno = conexion.Ejecutar("delete from Peliculas where PeliculaId =" +this.PeliculaId+ "; " + 
                                          "Delete from PeliculasActores where PeliculaId=" +this.PeliculaId+ "; " +
                                            "Delete from PeliculasGeneros where PeliculaId=" +this.PeliculaId);
            return retorno;
        }

        public override DataTable Listado(string campos, string condicion)
        {
            Conexion conexion = new Conexion();

            return conexion.ObtenerDatos("Select" + campos + " from Peliculas where " + condicion);
        }
        public override bool Buscar(int idBuscado)
        {
            Conexion conexion = new Conexion();
            DataTable dt = new DataTable();
            DataTable dtActores = new DataTable();
            DataTable dtGeneros = new DataTable();
            

            dt = conexion.ObtenerDatos(String.Format("Select PeliculaId,Titulo,Descripcion,Ano,Calificacion,Imagen,Video,Estudio from Peliculas where PeliculaId = '{0}'",idBuscado));
            if (dt.Rows.Count > 0)
            {
                this.PeliculaId = (int)dt.Rows[0]["PeliculaId"];
                this.Titulo = dt.Rows[0]["Titulo"].ToString();
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Ano = (int)dt.Rows[0]["Ano"];
                this.Calificacion = (int)dt.Rows[0]["Calificacion"];
                this.Imagen = dt.Rows[0]["Imagen"].ToString();
                this.Video = dt.Rows[0]["Video"].ToString();
                this.Estudio = dt.Rows[0]["Estudio"].ToString();

              

                dtActores = conexion.ObtenerDatos("Select p.ActorId,a.Nombre from PeliculasActores p Inner join Actores a on p.ActorId = a.ActorId where p.PeliculaId= " +this.PeliculaId);

                dtGeneros = conexion.ObtenerDatos("Select pg.GeneroId,g.Descripcion from PeliculasGeneros pg Inner join Generos g on pg.GeneroId = g.GeneroId Where pg.PeliculaId= " +this.PeliculaId);
                this.Actor.Clear();
                foreach (DataRow row in dtActores.Rows)
                {
                    this.AgregarActores((int)row["ActorId"], row["Nombre"].ToString());
                }
                this.Genero.Clear();
                foreach(DataRow row in dtGeneros.Rows)
                {
                    this.AgregarGeneros((int)row["GeneroId"], row["Descripcion"].ToString());
                }
            }




            return dt.Rows.Count > 0;
        }
        public DataTable Consultar(int id)
        {
            Conexion conexion = new Conexion();
            return conexion.ObtenerDatos("Select PeliculaId,Titulo,p.Descripcion,Ano,Calificacion,IMDB,c.Descripcion as Categoria,Imagen,Video from Peliculas as p join Categorias as c on p.CategoriaId = c.CategoriaId where PeliculaId= " + id);
        }
    }
}
