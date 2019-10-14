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
    public class CaminhaoController : Controller
    {
        private IEmpresaRepository _empRepository;
        private ICaminhaoRepository _camRepository;
        private IRotaRepository _rotRepository;

        public CaminhaoController(IEmpresaRepository empRepository,
                                  ICaminhaoRepository camRepository,
                                   IRotaRepository rotRepository)
        {
            _empRepository = empRepository;
            _camRepository = camRepository;
            _rotRepository = rotRepository;
        }

        [HttpGet]
        public IActionResult Detalhar(int codigo)
        {
            var rotas = _rotRepository
                .FindBy(c => c.CaminhaoId == codigo);

            var caminhao = _camRepository.FindById(codigo);

            var viewModel = new DetalheCaminhaoViewModel()
            {
                Caminhao = caminhao,
                Rotas = rotas,
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_camRepository.List());
        }

        private void CarregarSelectEmpresas()
        {
            var lista = _empRepository.List();
            ViewBag.empresas = new SelectList(lista, "EmpresaId", "RazaoSocial");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarSelectEmpresas();
            return View();
        }

     

        [HttpPost]
        public IActionResult Cadastrar(Caminhao caminhao)
        {
            _camRepository.Create(caminhao);
            _camRepository.Save();
            TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }


        [HttpPost]
        public IActionResult Atualizar(Caminhao caminhao)
        {
            _camRepository.Update(caminhao);
            _camRepository.Save();
            TempData["mensagem"] = "Atualizado com Sucesso!!";
            return RedirectToAction("Listar");
        }

        public IActionResult Atualizar(int id)
        {
            CarregarSelectEmpresas();

            var caminhao = _camRepository.FindById(id);

            return View(caminhao);
        }
        [HttpPost]
        public IActionResult Remover(int id)
        {
            var caminhao = _camRepository.FindById(id);
            _camRepository.Delete(id);
            _camRepository.Save();
            TempData["mensagem"] = "Removido com Sucesso!!";
            return RedirectToAction("Listar");
        }

        public IActionResult Pesquisar(string termoPesquisa)
        {
            var pesquisa = _camRepository.FindBy
                (c => c.Placa.Contains(termoPesquisa)).ToList();

            return View("Listar", pesquisa);
        }
    }
}