using SistemaDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Services
{
    public interface IArticuloService : IBaseService<Articulo>
    {
    }
    public class ArticuloService : BaseService<Articulo>, IArticuloService
    {
        public ArticuloService(SistemaDeComprasDbContext dbContext) : base(dbContext)
        {
        }
    }
}
