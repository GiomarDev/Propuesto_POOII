using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Entidadess
{
    public partial class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string NombreContacto { get; set; }
        public string CargoContacto { get; set; }
        public int IdPais { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }

    }
}
