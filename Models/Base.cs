using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Models
{
    public interface IBase 
    { 
        public int? Id { get; set; }
        public bool Estado { get; set; }
    }

    public class Base : IBase
    {
        public Base() => Estado = true;
        public int? Id { get; set; }
        public bool Estado { get; set; }
    }
}
