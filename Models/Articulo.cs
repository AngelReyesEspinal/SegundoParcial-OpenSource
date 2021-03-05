using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Models
{
    public class Articulo : Base
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public bool Existencia { get; set; }
        public int UnidadDeMedidaId { get; set; }
        public virtual UnidadDeMedida UnidadDeMedida { get; set; }
    }
}
