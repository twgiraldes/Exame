using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Interface.Repository;
using Data;
using Domain.Domain;

namespace Repository.Repositories
{
    public class RepositoryLaboratorioExame : RepositoryBase<laboratorioExame>, IRepositorylaboratorioExame
    {
        private readonly SqlContext _context;

        public RepositoryLaboratorioExame(SqlContext context) : base(context)
        {
            _context = context;
        }

        public laboratorioExame buscaLaboratorioExame(long idLab,long idExame)
        {
            return _context.laboratorioExame.Where(x => x.IdExame == idExame && x.IdLaboratorio==idLab).FirstOrDefault();
        }
    }
}
