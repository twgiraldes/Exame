using Core.Interface.Repository;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Domain;

namespace Repository.Repositories
{
    public abstract class RepositoryBase<TEntity>:  IDisposable, IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        private readonly SqlContext _context;

        public RepositoryBase(SqlContext context) 
        {
            _context = context;
        }
        public virtual void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public virtual void Update(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public virtual void Remove(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public virtual IEnumerable<TEntity> buscaTodos()
        {
            return _context.Set<TEntity>();
        }

        public virtual TEntity buscaPorId(long id)
        {
            return _context.Set<TEntity>().Where(x => x.id == id).FirstOrDefault();
        }
      
    }
}
