using DDD.Dominios;
using DDD.Entidadess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Manager
{
    public class ManagerPais
    {
        public List<Pais> Listar()
        {
            return new DomPais().Listar();
        }
    }
}
