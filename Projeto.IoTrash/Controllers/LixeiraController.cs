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
using Projeto.IoTrash.Repositories;

namespace Projeto.IoTrash.Controllers
{
    [Authorize]
    public class LixeiraController : Controller
    {
        private IRotaRepository _rotRepository;
        private ILixeiraRepository _lixRepository;


        public LixeiraController(IRotaRepository rotRepository,
                                 ILixeiraRepository lixRepository)
        {
            _rotRepository = rotRepository;
            _lixRepository = lixRepository;
        }
        [HttpGet]
        public IActionResult Listar(int rotaBuscar)
        {
            
            return View(_lixRepository.List());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var lista = _rotRepository.List();
            ViewBag.rotas = new SelectList(lista, "RotaId", "DescricaoRota");
            return View();
        }

     

        [HttpPost]
        public IActionResult Cadastrar(Lixeira lixeira)
        {
            _lixRepository.Create(lixeira);
            _lixRepository.Save();
            TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Atualizar(Lixeira lixeira)
        {
            _lixRepository.Update(lixeira);
            _lixRepository.Save();
            TempData["mensagem"] = "Atualizado com Sucesso!!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            var lixeira = _lixRepository.FindById(id);

            return View(lixeira);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var lixeira = _lixRepository.FindById(id);
            _lixRepository.Delete(id);
            _lixRepository.Save();
            TempData["mensagem"] = "Removido com Sucesso!!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Pesquisar(string termoPesquisa)
        {
            var pesquisa =
                 _lixRepository.FindBy
                 (c => c.Endereco.Contains(termoPesquisa)).ToList();

            return View("Listar", pesquisa);
        }
    }
}