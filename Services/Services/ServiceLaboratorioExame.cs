using System;
using System.Collections.Generic;
using System.Text;
using Core.Interface.Services;
using Core.Interface.Repository;
using Domain.Domain;

namespace Services.Services
{
    public class ServicelaboratorioExame : ServiceBase<laboratorioExame>, IServicelaboratorioExame
    {
        private readonly IRepositorylaboratorioExame _repositorylaboratorioExame;

        public ServicelaboratorioExame(IRepositorylaboratorioExame repositorylaboratorioExame) : base(repositorylaboratorioExame)
        {
            _repositorylaboratorioExame = repositorylaboratorioExame;
        }

        public laboratorioExame buscaLaboratorioExame(long idLab, long idExame)
        {
          return  _repositorylaboratorioExame.buscaLaboratorioExame(idLab, idExame);
        }
    }
}
