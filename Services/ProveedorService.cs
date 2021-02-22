using SistemaDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Services
{
    public interface IProveedorService : IBaseService<Proveedor>
    {
    }
    public class ProveedorService : BaseService<Proveedor>, IProveedorService
    {
        public ProveedorService(SistemaDeComprasDbContext dbContext) : base(dbContext)
        {
        }
    }
}
