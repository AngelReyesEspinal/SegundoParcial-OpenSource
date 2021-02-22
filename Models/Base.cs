using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Models
{
    public interface IBase 
    { 
        public int? Id { get; set; }
        public int Estado { get; set; }
    }

    public class Base : IBase
    {
        public int? Id { get; set; }
        public int Estado { get; set; }
    }
}
