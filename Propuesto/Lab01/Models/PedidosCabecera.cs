//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PedidosCabecera
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PedidosCabecera()
        {
            this.PedidosDetalle = new HashSet<PedidosDetalle>();
        }
    
        public int IdPedido { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public System.DateTime FechaPedido { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
        public string EnvioPedido { get; set; }
        public Nullable<int> CantidadPedido { get; set; }
        public string Destinatario { get; set; }
        public string DireccionDestinatario { get; set; }
        public string CiudadDestinatario { get; set; }
        public string ReferenciaDestnatario { get; set; }
        public string DepartamentoDestinatario { get; set; }
        public int IdCliente { get; set; }
        public Nullable<int> IdPaisDestinatario { get; set; }
    
        public virtual Empleados Empleados { get; set; }
        public virtual Clientes Clientes { get; set; }
        public virtual Paises Paises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidosDetalle> PedidosDetalle { get; set; }
    }
}