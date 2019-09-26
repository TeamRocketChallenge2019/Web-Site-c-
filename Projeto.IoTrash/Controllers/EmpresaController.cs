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
    public class EmpresaController : Controller
    {
        private static IList<Empresa> _lista = new List<Empresa>();

        private IoTrashContext _context;

        public EmpresaController(IoTrashContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Empresas.ToList());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
            TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }

           [HttpPost]
           public IActionResult Atualizar(Empresa empresa)
        {
            _context.Attach(empresa).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["mensagem"] = "Atualizado com Sucesso!!";
            return RedirectToAction("Listar");
        }
          [HttpGet]
          public IActionResult Atualizar(int id)
        {
            var empresa = _context.Empresas.Find(id);

            return View(empresa);
        }

        [HttpPost]
         public IActionResult Remover(int id)
        {
            var empresa = _context.Empresas.Find(id);
            _context.Empresas.Remove(empresa);
            _context.SaveChanges();
            TempData["mensagem"] = "Removido com Sucesso!!";
            return RedirectToAction("Listar");
        }

         public IActionResult Pesquisar(string termoPesquisa)
        {
            var pesquisa =
                _context.Empresas.Where
               (c => c.RazaoSocial.Contains(termoPesquisa) || c.CNPJ.Contains(termoPesquisa)).ToList();

            return View("Listar", pesquisa);
           
        }
    }
}