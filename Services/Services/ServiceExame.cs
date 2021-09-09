using System;
using System.Collections.Generic;
using System.Text;
using Core.Interface.Services;
using Core.Interface.Repository;
using Domain.Domain;

namespace Services.Services
{
    public class Serviceexame : ServiceBase<exame>, IServiceExame
    {
        private readonly IRepositoryExame _repositoryexame;

        public Serviceexame(IRepositoryExame repositoryexame) : base(repositoryexame)
        {
            _repositoryexame = repositoryexame;
        }
        public List<exame> buscaAtivos()
        {
            return _repositoryexame.buscaAtivos();


        }
        public List<exame> buscaPorNome(string nome)
        {

            return _repositoryexame.buscaPorNome(nome);
        }
    }
}
