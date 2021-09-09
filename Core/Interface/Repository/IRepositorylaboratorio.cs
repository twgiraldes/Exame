using System;
using System.Collections.Generic;
using System.Text;
using Domain.Domain;

namespace Core.Interface.Repository
{
    public interface IRepositorylaboratorio : IRepositoryBase<laboratorio>
    {
        public List<laboratorio> buscaAtivos();
        public List<laboratorio> buscaPorNome(string nome);
        public List<laboratorio> buscaPorExame(string nomeExame);
    }
}
