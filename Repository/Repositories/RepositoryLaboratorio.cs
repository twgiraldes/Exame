using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Interface.Repository;
using Data;
using Domain.Domain;

namespace Repository.Repositories
{
    public class RepositoryLaboratorio : RepositoryBase<laboratorio>, IRepositorylaboratorio
    {
        private readonly SqlContext _context;

        public RepositoryLaboratorio(SqlContext context) : base(context)
        {
            _context = context;
        }
        public List<laboratorio> buscaAtivos()
        {
            return _context.laboratorio.Where(x => x.status == true).ToList();
        }
        public List<laboratorio> buscaPorNome(string nome)
        {
            return _context.Set<laboratorio>().Where(x => nome.Contains(x.nome)).ToList();
        }

        public List<laboratorio> buscaPorExame(string nomeExame)
        {


            var result = from a in _context.laboratorio
                         join h in _context.laboratorioExame on a.id equals h.IdLaboratorio
                         join c in _context.exame on h.IdExame equals c.id
                         where c.nome.Contains(nomeExame)
                         select a;


            return result.ToList();

        }
    }
}
