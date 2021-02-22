using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Models
{
    public class SistemaDeComprasDbContext : DbContext
    {
        public SistemaDeComprasDbContext()
        {
        }
        public SistemaDeComprasDbContext(DbContextOptions<SistemaDeComprasDbContext> options) : base(options)
        {
        }

        public  virtual DbSet<Departamento> Departamentos { get; set; }
        public  virtual DbSet<UnidadDeMedida> UnidadesDeMedida { get; set; }
        public  virtual DbSet<Proveedor> Proveedores { get; set; }
        public  virtual DbSet<Articulo> Articulos { get; set; }
        public  virtual DbSet<OrdenDeCompra> OrdenesDeCompra { get; set; }
    }
}
