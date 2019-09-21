using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto.IoTrash.Models;
using Projeto.IoTrash.Persistence;

namespace Projeto.IoTrash.Controllers
{
    public class LixeiraController : Controller
    {

        private static IList<Lixeira> _lista = new List<Lixeira>();

        private IoTrashContext _context;


        public LixeiraController(IoTrashContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Lixeiras.ToList());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Cadastrar(Lixeira lixeira)
        {
            _context.Lixeiras.Add(lixeira);
            _context.SaveChanges();
            TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }

          [HttpPost]
          public IActionResult Atualizar(Lixeira lixeira)
        {
            _context.Attach(lixeira).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["mensagem"] = "Atualizado com Sucesso!!";
            return RedirectToAction("Listar");
        }

         [HttpGet]
         public IActionResult Atualizar(int id)
        {
            var lixeira = _context.Lixeiras.Find(id);

            return View(lixeira);
        }

         [HttpPost]
         public IActionResult Remover(int id)
        {
            var lixeira = _context.Lixeiras.Find(id);
            _context.Lixeiras.Remove(lixeira);
            _context.SaveChanges();
            TempData["mensagem"] = "Removido com Sucesso!!";
            return RedirectToAction("Listar");
        }

         [HttpGet]
         public IActionResult Pesquisar(string termoPesquisa)
        {
            var pesquisa =
                 _context.Lixeiras.Where
                 (c => c.Endereco.Contains(termoPesquisa)).ToList();

            return View("Listar", pesquisa);
        }
    }
}