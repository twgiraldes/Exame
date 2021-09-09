
using System.Collections.Generic;

namespace Core.Interface.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);

      

        TEntity buscaPorId(long id);

    }
}
