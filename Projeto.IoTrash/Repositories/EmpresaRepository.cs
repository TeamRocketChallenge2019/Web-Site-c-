using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Projeto.IoTrash.Data;
using Projeto.IoTrash.Models;

namespace Projeto.IoTrash.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {

        private ApplicationDbContext _context;

        public EmpresaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
        }

        public void Delete(int id)
        {
            var empresa = _context.Empresas.Find(id);
            _context.Empresas.Remove(empresa);
        }

        public IList<Empresa> FindBy(Expression<Func<Empresa, bool>> filtro)
        {
            return _context.Empresas.Where(filtro).ToList();
        }

        public Empresa FindById(int id)
        {
            return _context.Empresas.Find(id);
        }

        public IList<Empresa> List()
        {
            return _context.Empresas.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Empresa empresa)
        {
            _context.Empresas.Update(empresa);
        }
    }
}
