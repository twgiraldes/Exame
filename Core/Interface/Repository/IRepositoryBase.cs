using System.Collections.Generic;

namespace Core.Interface.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> buscaTodos();

        TEntity buscaPorId(long id);

        void Dispose();
    }
}
