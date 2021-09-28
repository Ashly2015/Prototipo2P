using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaModelo
{
    public class Sentencias
    {
        private Conexion cn = new Conexion();
        private OdbcCommand Comm;

     
        //mantenimiento Linea

        public void funInsertar(string Id, string Nombre, int estado)
        {
            string cadena = "INSERT INTO" +
            " `sic2`.`lineas` VALUES (" + "'" + Id + "', '" + Nombre + "' , " + estado + ");";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funModificar(string Id, string Nombre, int estado)
        {
            string cadena = "UPDATE sic2.linea set codigo_linea ='" + Id
              + "',nombre ='" + Nombre + "',estado = " + estado + "  where pkId= '" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funEliminarLinea(string Id)
        {
            string cadena = "delete from sic2.linea where codigo_linea ='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public (string, int) funBuscar(string id, string nombre, int estado)
        {
            string Query = "select * from `sic2`.`linea` where codigo_linea='" + id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                nombre = busqueda["nombre_linea"].ToString();
                estado = int.Parse(busqueda["estatus_linea"].ToString());
            }

            return (nombre, estado);
        }



        //mantenimiento Producto
        public OdbcDataReader llenarcbxLinea(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxMarca(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        
        public string consultaLinea(string nombre)
        {

            string id = "";
            string Query = "select * from `sic2`.`lineas` where nombre_linea='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["codigo_linea"].ToString();

            }


            return id;
        }

        public string consultaMarca(string nombre)
        {

            string id = "";
            string Query = "select * from `sic2`.`marcas` where nombre_marca='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["codigo_marca"].ToString();

            }


            return id;
        }

        

        
    }
}

