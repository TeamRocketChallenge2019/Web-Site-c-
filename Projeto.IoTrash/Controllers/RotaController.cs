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
    public class RotaController : Controller
    {

        private static IList<Rota> _lista = new List<Rota>();

        private IoTrashContext _context;


        public RotaController(IoTrashContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Rotas.ToList());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Rota rota)
        {
            _context.Rotas.Add(rota);
            _context.SaveChanges();
            TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }
          [HttpGet]
         public IActionResult Atualizar(Rota rota)
        {
            _context.Attach(rota).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["mensagem"] = "Atualizado com Sucesso!!";
            return RedirectToAction("Listar");
        }
         [HttpPost]
         public IActionResult Atualizar(int id)
        {
            var rota = _context.Rotas.Find(id);

            return View(rota);
        }
          [HttpPost]
          public IActionResult Remover(int id)
        {
            var rota = _context.Rotas.Find(id);
            _context.Rotas.Remove(rota);
            _context.SaveChanges();
            TempData["mensagem"] = "Removido com Sucesso!!";
            return RedirectToAction("Listar");
        }
        
    }
}