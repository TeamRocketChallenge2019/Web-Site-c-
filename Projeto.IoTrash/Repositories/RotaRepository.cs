using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Projeto.IoTrash.Data;
using Projeto.IoTrash.Models;

namespace Projeto.IoTrash.Repositories
{
    public class RotaRepository : IRotaRepository
    {
        private ApplicationDbContext _context;

        public RotaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Rota rota)
        {
            _context.Rotas.Add(rota);
        }

        public void Delete(int id)
        {
            var rota = _context.Rotas.Find(id);
            _context.Rotas.Remove(rota);
        }

        public IList<Rota> FindBy(Expression<Func<Rota, bool>> filtro)
        {
            return _context.Rotas.Where(filtro).ToList();
        }

        public Rota FindById(int id)
        {
            return _context.Rotas.Find(id);
        }

        public IList<Rota> List()
        {
            return _context.Rotas.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Rota rota)
        {
            _context.Rotas.Update(rota);
        }
    }
}
