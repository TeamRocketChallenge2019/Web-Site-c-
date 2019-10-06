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
using Projeto.IoTrash.ViewModels;

namespace Projeto.IoTrash.Controllers
{
    [Authorize]
    public class RotaController : Controller
    {


        private IRotaRepository _rotRepository;
        private ICaminhaoRepository _camRepository;
        private ILixeiraRepository _lixRepository;


        public RotaController(IRotaRepository rotRepository,
                               ICaminhaoRepository camRepository,
                                ILixeiraRepository lixRepository)
        {
            _rotRepository = rotRepository;
            _camRepository = camRepository;
            _lixRepository = lixRepository;
        }

        [HttpGet]
        public IActionResult Detalhar(int codigo)
        {
            var lixeiras = _lixRepository
                .FindBy(c => c.RotaId == codigo);

            var rota = _rotRepository.FindById(codigo);

            var viewModel = new DetalheRotaViewModel()
            {
                Rota = rota,
                Lixeiras = lixeiras,
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Listar(int caminhaoBuscar)
        {
            

            return View(_rotRepository.List());

        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var lista = _camRepository.List();
            ViewBag.caminhoes = new SelectList(lista, "CaminhaoId", "Placa");
            return View();
        }



        [HttpPost]
        public IActionResult Cadastrar(Rota rota)
        {
            _rotRepository.Create(rota);
            _rotRepository.Save();
            TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }
        [HttpPost]
        public IActionResult Atualizar(Rota rota)
        {
            _rotRepository.Update(rota);
            _rotRepository.Save();
            TempData["mensagem"] = "Atualizado com Sucesso!!";
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            var rota = _rotRepository.FindById(id);

            return View(rota);
        }
        [HttpPost]
        public IActionResult Remover(int id)
        {
            var rota = _rotRepository.FindById(id);
            _rotRepository.Delete(id);
            _rotRepository.Save();
            TempData["mensagem"] = "Removido com Sucesso!!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Pesquisar(string termoPesquisa)
        {
            var pesquisa =
                 _rotRepository.FindBy
                 (c => c.DescricaoRota.Contains(termoPesquisa)).ToList();

            return View("Listar", pesquisa);
        }

    }
}