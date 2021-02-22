using SistemaDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Services
{
    public interface IUnidadDeMedidaService : IBaseService<Models.UnidadDeMedida>
    {
    }
    public class UnidadDeMedidaService : BaseService<Models.UnidadDeMedida>, IUnidadDeMedidaService
    {
        public UnidadDeMedidaService(SistemaDeComprasDbContext dbContext) : base(dbContext)
        {
        }
    }
}
