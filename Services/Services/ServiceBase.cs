using Core.Interface.Repository;
using Core.Interface.Services;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);

        }
        public void Update(TEntity obj)
        {
            _repository.Update(obj);

        }
        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);

        }
        public void Dispose()
        {
            _repository.Dispose();
        }

      

        public TEntity buscaPorId(long id)
        {
            return _repository.buscaPorId(id);
        }
    }
}
