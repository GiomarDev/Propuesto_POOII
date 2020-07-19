using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Dominio
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
