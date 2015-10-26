using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public class Actores:ClaseMaestra
   {
        public int ActorId { get; set; }
        public string Nombre { get; set; }

        public Actores()
        {
            this.ActorId = 0;
            this.Nombre = "";
        }
        public Actores(int actorId,string nombre)
        {
            this.ActorId = actorId;
            this.Nombre = nombre;
        }

        public override bool Insertar()
        {
            Conexion conexion = new Conexion();

            return conexion.Ejecutar(string.Format("Insert into Actores(Nombre) values('{0}')",this.Nombre));
        }

        public override bool Eliminar()
        {
            Conexion conexion = new Conexion();

            return conexion.Ejecutar(string.Format("Delete from Actores where ActorId = {0}",this.ActorId));
        }

        public override bool Editar()
        {
            Conexion conexion = new Conexion();

            return conexion.Ejecutar(string.Format("Update Actores set Nombre = '{0}' where ActorId = '{1}'",this.Nombre,this.ActorId));
        }

        public override bool Buscar(int idBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string campos, string condicion)
        {
            Conexion conexion = new Conexion();

            return conexion.ObtenerDatos("Select " +campos+ " from Actores where " +condicion);
        }
        public DataTable GetId(string cadena)
        {
            Conexion conexion = new Conexion();

            return conexion.ObtenerDatos(string.Format("select ActorId from Actores where Nombre = '{0}'", cadena));
        }
    }
}
