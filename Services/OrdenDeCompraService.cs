using SistemaDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Services
{
    public interface IOrdenDeCompraService : IBaseService<Models.OrdenDeCompra>
    {
        IQueryable<OrdenDeCompra> GetOrdersByDepartmentOrProvider(int? departamentoId, int? proveedorId);
    }
    public class OrdenDeCompraService : BaseService<Models.OrdenDeCompra>, IOrdenDeCompraService
    {
        public OrdenDeCompraService(SistemaDeComprasDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<OrdenDeCompra> GetOrdersByDepartmentOrProvider(int? departamentoId, int? proveedorId)
        {
            var query = _dbContext.Set<OrdenDeCompra>().AsQueryable();
            if (departamentoId != null && proveedorId != null) 
            {
                query = query.Where(x => x.ProveedorId == proveedorId && x.DepartamentoId == departamentoId);
            } 
            else if (departamentoId != null || proveedorId != null) 
            {
                query = departamentoId != null 
                    ? query.Where(x => x.DepartamentoId == departamentoId) 
                    : query.Where(x => x.ProveedorId == proveedorId);
            } 
            return query;
        }
    }
}
