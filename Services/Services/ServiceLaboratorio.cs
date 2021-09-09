using System;
using System.Collections.Generic;
using System.Text;
using Core.Interface.Services;
using Core.Interface.Repository;
using Domain.Domain;

namespace Services.Services
{
    public class ServiceLaboratorio : ServiceBase<laboratorio>, IServicelaboratorio
    {
        private readonly IRepositorylaboratorio _repositoryLaboratorio;

        public ServiceLaboratorio(IRepositorylaboratorio repositoryLaboratorio) : base(repositoryLaboratorio)
        {
            _repositoryLaboratorio = repositoryLaboratorio;
        }
        public List<laboratorio> buscaAtivos()
        {
            return _repositoryLaboratorio.buscaAtivos();


        }

        public List<laboratorio> buscaPorExame(string nomeExame)
        {
            return _repositoryLaboratorio.buscaPorExame(nomeExame);
        }

        public List<laboratorio> buscaPorNome(string nome)
        {
            return _repositoryLaboratorio.buscaPorNome(nome);
        }
    }
}
