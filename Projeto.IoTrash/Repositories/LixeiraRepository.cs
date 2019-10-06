using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Projeto.IoTrash.Data;
using Projeto.IoTrash.Models;

namespace Projeto.IoTrash.Repositories
{
    public class LixeiraRepository : ILixeiraRepository
    {

        private ApplicationDbContext _context;

        public LixeiraRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Lixeira lixeira)
        {
            _context.Lixeiras.Add(lixeira);
        }

        public void Delete(int id)
        {
            var lixeira = _context.Lixeiras.Find(id);
            _context.Lixeiras.Remove(lixeira);
        }

        public IList<Lixeira> FindBy(Expression<Func<Lixeira, bool>> filtro)
        {
            return _context.Lixeiras.Where(filtro).ToList();

        }

        public Lixeira FindById(int id)
        {
            return _context.Lixeiras.Find(id);
        }

        public IList<Lixeira> List()
        {
            return _context.Lixeiras.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Lixeira lixeira)
        {
            _context.Lixeiras.Update(lixeira);
        }
    }
}
