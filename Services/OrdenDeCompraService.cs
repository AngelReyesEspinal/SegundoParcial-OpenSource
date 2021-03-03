using SistemaDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Services
{
    public interface IOrdenDeCompraService : IBaseService<Models.OrdenDeCompra>
    {
        IQueryable<OrdenDeCompra> GetOrdenByDepartamento(int? departamentoId, int? proveedorId);
    }
    public class OrdenDeCompraService : BaseService<Models.OrdenDeCompra>, IOrdenDeCompraService
    {
        public OrdenDeCompraService(SistemaDeComprasDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<OrdenDeCompra> GetOrdenByDepartamento(int? departamentoId, int? proveedorId)
        {
            var data = _dbContext.Set<OrdenDeCompra>()
                                 .AsQueryable()
                                 .Where(x =>
                                    proveedorId != null ? x.ProveedorId == proveedorId : true &&
                                    departamentoId != null ? x.DepartamentoId == departamentoId : true
                                 );
            return data;
        }
    }
}
