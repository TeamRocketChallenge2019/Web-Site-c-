using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.IoTrash.Models;

namespace Projeto.IoTrash.Controllers
{
    public class EmpresaController : Controller
    {
        private static IList<Empresa> _lista = new List<Empresa>();

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Empresa empresa)
        {
            _lista.Add(empresa);
            TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }
    }
}