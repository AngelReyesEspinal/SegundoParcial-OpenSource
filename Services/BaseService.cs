using Microsoft.EntityFrameworkCore;
using SistemaDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCompras.Services
{
    public interface IBaseService<TEntity>
    {
        IQueryable<TEntity> GetAll();
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(int id);
    }
    public class BaseService<TEntity> where TEntity : class, IBase
    {
        protected readonly SistemaDeComprasDbContext _dbContext;
       
        public BaseService(SistemaDeComprasDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            return _dbContext.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }

        public int Delete(int id)
        {
            var entity = _dbContext.Set<TEntity>().AsQueryable().FirstOrDefault(x => x.Id == id);
            _dbContext.Set<TEntity>().Remove(entity);
            return _dbContext.SaveChanges();
        }
    }
}
