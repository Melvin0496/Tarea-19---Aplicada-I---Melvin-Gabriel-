using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Estudios:ClaseMaestra
    {
        public int EstudioId { get; set; }
        public string Nombre { get; set; }

        public Estudios()
        {
            this.EstudioId = 0;
            this.Nombre = "";
        }
        public Estudios(int estudiId,string nombre)
        {
            this.EstudioId = estudiId;
            this.Nombre = nombre;
        }

        public override bool Insertar()
        {
            Conexion conexion = new Conexion();

            return conexion.Ejecutar(string.Format("Insert into Estudios(Nombre) values('{0}')",this.Nombre));
        }

        public override bool Eliminar()
        {
            Conexion conexion = new Conexion();

            return conexion.Ejecutar(string.Format("Delete from Estudios where EstudioId = {0}",this.EstudioId));
        }

        public override bool Editar()
        {
            Conexion conexion = new Conexion();

            return conexion.Ejecutar(string.Format("Update Estudios set Nombre = '{0}' where EstudioId = '{1}'",this.Nombre,this.EstudioId));
        }

        public override bool Buscar(int idBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string campos, string condicion)
        {
            Conexion conexion = new Conexion();

            return conexion.ObtenerDatos("Select " +campos+ " from Estudios where " +condicion);
        }
    }
}
