using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Models
{
    public class OrdenDeCompra : Base
    {
        public int NumeroDeOrden { get; set; }
        public DateTime FechaOrden { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public int ArticuloId { get; set; }
        public int UnidadDeMedidaId { get; set; }
        public virtual UnidadDeMedida UnidadDeMedida { get; set; }
        public virtual Articulo Articulo { get; set; }
    }
}
