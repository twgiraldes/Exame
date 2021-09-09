using System;
using System.Collections.Generic;
using System.Text;
using Domain.Domain;

namespace Core.Interface.Services
{
    public interface IServicelaboratorio : IServiceBase<laboratorio>
    {
        public List<laboratorio> buscaAtivos();
        public List<laboratorio> buscaPorNome(string nome);
        public List<laboratorio> buscaPorExame(string nomeExame);
    }
}
