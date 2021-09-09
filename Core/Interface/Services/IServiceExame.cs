using System;
using System.Collections.Generic;
using System.Text;
using Domain.Domain;

namespace Core.Interface.Services
{
    public interface IServiceExame : IServiceBase<exame>
    {
        public List<exame> buscaAtivos();
        public List<exame> buscaPorNome(string nome);
    }
}
