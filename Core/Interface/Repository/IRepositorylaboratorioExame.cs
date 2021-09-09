using System;
using System.Collections.Generic;
using System.Text;
using Domain.Domain;

namespace Core.Interface.Repository
{
    public interface IRepositorylaboratorioExame : IRepositoryBase<laboratorioExame>
    {
        public laboratorioExame buscaLaboratorioExame(long idLab, long idExame);
    }
}
