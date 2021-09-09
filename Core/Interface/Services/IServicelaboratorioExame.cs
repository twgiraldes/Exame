using System;
using System.Collections.Generic;
using System.Text;
using Domain.Domain;

namespace Core.Interface.Services
{
    public interface IServicelaboratorioExame : IServiceBase<laboratorioExame>
    {
        public laboratorioExame buscaLaboratorioExame(long idLab, long idExame);
    }

}
