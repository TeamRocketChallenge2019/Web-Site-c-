using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto.IoTrash.Data;
using Projeto.IoTrash.Models;

namespace Projeto.IoTrash.Controllers
{
    [Authorize]
    public class CaminhaoController : Controller
    {

        private static IList<Caminhao> _lista = new List<Caminhao>();

        private ApplicationDbContext _context;

        public CaminhaoController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Listar(int empresaBuscar)
        {
            CarregarSelectEmpresas();
            return View(_context.Caminhoes.Include(e => e.Empresa)
                .Where(e => e.EmpresaId == empresaBuscar || empresaBuscar == 0).ToList());
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarSelectEmpresas();
            return View();
        }

        private void CarregarSelectEmpresas()
        {
            var lista = _context.Empresas.ToList();
            ViewBag.empresas = new SelectList(lista, "EmpresaId", "RazaoSocial");
        }

        [HttpPost]
        public IActionResult Cadastrar(Caminhao caminhao)
        {
            _context.Caminhoes.Add(caminhao);
            _context.SaveChanges();
            TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }
        [HttpPost]
        public IActionResult Atualizar(Caminhao caminhao)
        {
            _context.Attach(caminhao).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["mensagem"] = "Atualizado com Sucesso!!";
            return RedirectToAction("Listar");
        }

        public IActionResult Atualizar(int id)
        {
            var caminhao = _context.Caminhoes.Find(id);

            return View(caminhao);
        }
        [HttpPost]
        public IActionResult Remover(int id)
        {
            var caminhao = _context.Caminhoes.Find(id);
            _context.Caminhoes.Remove(caminhao);
            _context.SaveChanges();
            TempData["mensagem"] = "Removido com Sucesso!!";
            return RedirectToAction("Listar");
        }

        public IActionResult Pesquisar(string termoPesquisa)
        {
            var pesquisa = _context.Caminhoes.Where
                (c => c.Placa.Contains(termoPesquisa)).ToList();

            return View("Listar", pesquisa);
        }
    }
}