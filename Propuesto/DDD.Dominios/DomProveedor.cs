using DDD.ADOSql;
using DDD.Entidadess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace DDD.Dominios
{
    public class DomProveedor
    {
        public List<string> Mensajes { get; set; }

        public List<Proveedor> Listar()
        {
            return new ADOSqlProveedor().Listar();
        }

        public int Insertar(Proveedor obj)
        {
            return new ADOSqlProveedor().Insertar(obj);
        }

        public int Actualizar(Proveedor obj)
        {
            return new ADOSqlProveedor().Actualizar(obj);
        }

        public Proveedor Obtener(int id)
        {
            return new ADOSqlProveedor().Obtener(id);
        }

        public int Eliminar(int id)
        {
            return new ADOSqlProveedor().Eliminar(id);
        }
    }
}
