using DDD.Dominios;
using DDD.Entidadess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Manager
{
    public class ManagerProveedor
    {
        public List<Proveedor> Listar()
        {
            return new DomProveedor().Listar();
        }

        public int Insertar(Proveedor obj)
        {
            return new DomProveedor().Insertar(obj);
        }

        public int Actualizar(Proveedor obj)
        {
            return new DomProveedor().Actualizar(obj);
        }

        public Proveedor Obtener(int id)
        {
            return new DomProveedor().Obtener(id);
        }

        public int Eliminar(int id)
        {
            return new DomProveedor().Eliminar(id);
        }


    }
}
