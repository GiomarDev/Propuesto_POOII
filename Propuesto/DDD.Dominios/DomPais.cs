using DDD.ADOSql;
using DDD.Entidadess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Dominios
{
    public class DomPais
    {
        public List<string> Mensajes { get; set; }

        public List<Pais> Listar()
        {
            return new ADOSqlPais().Listar();
        }

    }
}
