using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        //MantenimientoLinea
        public void insertarLinea(string Id, string Nombre, string estado)
        {
            sn.funInsertarLinea(Id, Nombre, estado);
        }

        public void modificarLinea(string Id, string Nombre, string estado)
        {
            sn.funModificarLinea(Id, Nombre, estado);
        }

        public (string, string) buscarLinea(string id, string nombre, string estado)
        {
            sn.funBuscarLinea(id, nombre, estado);
            return (nombre, estado);
        }

        public void eliminarLinea(string id)
        {
            sn.funEliminarLinea(id);
        }


        //MantenimientoMarca
        public void insertarMarca(string Id, string Nombre, string estado)
        {
            sn.funInsertarMarca(Id, Nombre, estado);
        }

        public void modificarMarca(string Id, string Nombre, string estado)
        {
            sn.funModificarMarca(Id, Nombre, estado);
        }

        public (string, string) buscarMarca(string id, string nombre, string estado)
        {
            sn.funBuscarMarca(id, nombre, estado);
            return (nombre, estado);
        }

        public void eliminarMarca(string id)
        {
            sn.funEliminarMarca(id);
        }
    }
}
