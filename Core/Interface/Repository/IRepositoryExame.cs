using System;
using System.Collections.Generic;
using System.Text;
using Domain.Domain;

namespace Core.Interface.Repository
{
    public interface IRepositoryExame : IRepositoryBase<exame>
    {
        public List<exame> buscaAtivos();
        public List<exame> buscaPorNome(string nome);
    }
}
