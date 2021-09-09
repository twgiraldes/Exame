using System;
using System.Collections.Generic;
using System.Text;
using Core.Interface.Repository;
using Data;
using Domain.Domain;
using System.Linq;
namespace Repository.Repositories
{
    public class RepositoryExame : RepositoryBase<exame>, IRepositoryExame
    {
        private readonly SqlContext _context;

        public RepositoryExame(SqlContext context) : base(context)
        {
            _context = context;
        }
        public List<exame> buscaAtivos()
        {
            return _context.exame.Where(x => x.status==true).ToList();
        }
        public  List<exame> buscaPorNome(string nome)
        {
            return _context.Set<exame>().Where(x => nome.Contains(x.nome)).ToList();
        }
    }
}
