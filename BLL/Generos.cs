using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Generos : ClaseMaestra
    {

        public int GeneroId { get; set; }
        public string Descripcion { get; set; }

        public Generos()
        {
            GeneroId = 0;
            Descripcion = "";
        }
        public Generos(int generoId,string descripcion)
        {
            this.GeneroId = generoId;
            this.Descripcion = descripcion;
        }
        public override bool Editar()
        {
            Conexion conexion = new Conexion();

            return conexion.Ejecutar(string.Format("Update Generos set Descripcion = '{0}' where GeneroId = {1}",this.Descripcion,this.GeneroId));
        }

        public override bool Eliminar()
        {
            Conexion conexion = new Conexion();

            return conexion.Ejecutar("Delete from Generos where GeneroId = "+this.GeneroId); 
        }

        public override bool Insertar()
        {
            Conexion conexion = new Conexion();

            return conexion.Ejecutar(string.Format("Insert into Generos (Descripcion) values('{0}')",this.Descripcion)); 
        }

        public override DataTable Listado(string campos, string condicion)
        {
            Conexion conexion = new Conexion();

            return conexion.ObtenerDatos("Select " + campos + " from Generos where " + condicion);
        }

        public override bool Buscar(int idBuscado)
        {
            DataTable dataTable = new DataTable();
            Conexion conexion = new Conexion();

            dataTable = conexion.ObtenerDatos(string.Format("Select *from Generos where GeneroId = '{0}'", this.GeneroId));
            if(dataTable.Rows.Count > 0)
            {
                this.GeneroId = (int)dataTable.Rows[0]["GeneroId"];
                this.Descripcion = dataTable.Rows[0]["Descripcion"].ToString();
            }
           

            return dataTable.Rows.Count > 0;

            
        }
        public DataTable GetIdGenero(string cadena)
        {
            Conexion conexion = new Conexion();
            return conexion.ObtenerDatos(string.Format("select GeneroId from Generos where Descripcion = '{0}'", cadena));
        }
    }
}
