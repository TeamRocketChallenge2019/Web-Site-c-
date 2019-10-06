using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto.IoTrash.Data;
using Projeto.IoTrash.Models;

namespace Projeto.IoTrash.Repositories
{
    public class CaminhaoRepository : ICaminhaoRepository
    { 
        private ApplicationDbContext _context;

    public CaminhaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }


        public void Create(Caminhao caminhao)
        {
            _context.Caminhoes.Add(caminhao);
        }

        public void Delete(int id)
        {
            var caminhao = _context.Caminhoes.Find(id);
            _context.Caminhoes.Remove(caminhao);
        }

        public IList<Caminhao> FindBy(Expression<Func<Caminhao, bool>> filtro)
        {
            return _context.Caminhoes.Where(filtro).ToList();
        }

        public Caminhao FindById(int id)
        {
            return _context.Caminhoes.Find(id);
        }

        public IList<Caminhao> List()
        {
            return _context.Caminhoes.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Caminhao caminhao)
        {
            _context.Caminhoes.Update(caminhao);
        }
    }
}
