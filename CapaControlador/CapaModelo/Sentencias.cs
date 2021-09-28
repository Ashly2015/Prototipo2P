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

        public void funInsertarLinea(string Id, string Nombre, string estado)
        {
            try { 
            string cadena = "INSERT INTO" +
           " `lineas` VALUES (" + "'" + Id + "', '" + Nombre + "' , '" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    
        public void funModificarLinea(string Id, string Nombre, string estado)
        {
            try
            {
                string cadena = "UPDATE sic2.lineas set codigo_linea ='" + Id
              + "',nombre ='" + Nombre + "',estado = '" + estado + "'  where codigo_linea= '" + Id + "';";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)

            {
                Console.WriteLine("Error: " + ex);
            }
        }

        public void funEliminarLinea(string Id)
        {
            try
            {
                string cadena = "delete from sic2.lineas where codigo_linea ='" + Id + "';";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)

            {
                Console.WriteLine("Error: " + ex);
            }
        }

        public (string, string) funBuscarLinea(string id, string nombre, string estado)
        {
            try
            {
                string Query = "select * from `sic2`.`lineas` where codigo_linea='" + id + "';";

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                if (busqueda.Read())
                {
                    nombre = busqueda["nombre_linea"].ToString();
                    estado = busqueda["estatus_linea"].ToString();
                }
            }
            catch (Exception ex)

            {
                Console.WriteLine("Error: " + ex);
            }

            return (nombre, estado);
            
        }



        //mantenimiento Marca

        public void funInsertarMarca(string Id, string Nombre, string estado)
        {
            try
            {
                string cadena = "INSERT INTO" +
               " `marcas` VALUES (" + "'" + Id + "', '" + Nombre + "' , '" + estado + "');";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        public void funModificarMarca(string Id, string Nombre, string estado)
        {
            try
            {
                string cadena = "UPDATE sic2.marcas set codigo_linea ='" + Id
              + "',nombre ='" + Nombre + "',estado = '" + estado + "'  where codigo_marca= '" + Id + "';";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)

            {
                Console.WriteLine("Error: " + ex);
            }
        }

        public void funEliminarMarca(string Id)
        {
            try
            {
                string cadena = "delete from sic2.marcas where codigo_marca ='" + Id + "';";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)

            {
                Console.WriteLine("Error: " + ex);
            }
        }

        public (string, string) funBuscarMarca(string id, string nombre, string estado)
        {
            try
            {
                string Query = "select * from `sic2`.`marcas` where codigo_marca='" + id + "';";

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                if (busqueda.Read())
                {
                    nombre = busqueda["nombre_marca"].ToString();
                    estado = busqueda["estatus_marca"].ToString();
                }
            }
            catch (Exception ex)

            {
                Console.WriteLine("Error: " + ex);
            }

            return (nombre, estado);

        }





    }

        

        
    
}

