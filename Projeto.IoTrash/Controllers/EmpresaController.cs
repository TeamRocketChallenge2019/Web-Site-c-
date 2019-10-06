using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto.IoTrash.Data;
using Projeto.IoTrash.Models;
using Projeto.IoTrash.Repositories;
using Projeto.IoTrash.ViewModels;

namespace Projeto.IoTrash.Controllers
{
    [Authorize]
    public class EmpresaController : Controller
    {

        private IEmpresaRepository _empRepository;
        private ICaminhaoRepository _camRepository;

        public EmpresaController(IEmpresaRepository empRepository,
                                  ICaminhaoRepository camRepository)
        {
            _empRepository = empRepository;
            _camRepository = camRepository;
        }

        [HttpGet]
        public IActionResult Detalhar(int codigo)
        {
            var caminhoes = _camRepository
                .FindBy(c => c.EmpresaId == codigo);

            var empresa = _empRepository.FindById(codigo);

            var viewModel = new DetalheEmpresaViewModel()
            {
                Empresa = empresa,
                Caminhoes = caminhoes,
            };
            return View(viewModel);
            }
        

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_empRepository.List());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Empresa empresa)
        {
           _empRepository.Create(empresa);
           _empRepository.Save();
           TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Atualizar(Empresa empresa)
        {
            _empRepository.Update(empresa);
            _empRepository.Save();
            TempData["mensagem"] = "Atualizado com Sucesso!!";
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            var empresa = _empRepository.FindById(id);

            return View(empresa);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var empresa = _empRepository.FindById(id);
            _empRepository.Delete(id);
            _empRepository.Save();
            TempData["mensagem"] = "Removido com Sucesso!!";
            return RedirectToAction("Listar");
        }

        public IActionResult Pesquisar(string termoPesquisa)
        {
            var pesquisa =
                _empRepository.FindBy
               (c => c.RazaoSocial.Contains(termoPesquisa) || c.CNPJ.Contains(termoPesquisa)).ToList();

            return View("Listar", pesquisa);

        }
    }
}