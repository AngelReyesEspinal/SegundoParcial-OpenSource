using SistemaDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Services
{
    public interface IOrdenDeCompraService : IBaseService<Models.OrdenDeCompra>
    {
    }
    public class OrdenDeCompraService : BaseService<Models.OrdenDeCompra>, IOrdenDeCompraService
    {
        public OrdenDeCompraService(SistemaDeComprasDbContext dbContext) : base(dbContext)
        {
        }
    }
}
