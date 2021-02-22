using SistemaDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Services.Departamento
{
    public interface IDepartamentoService : IBaseService<Models.Departamento>
    {
    }
    public class DepartamentoService : BaseService<Models.Departamento>, IDepartamentoService
    {
        public DepartamentoService(SistemaDeComprasDbContext dbContext) : base (dbContext) 
        {
        }
    }
}
