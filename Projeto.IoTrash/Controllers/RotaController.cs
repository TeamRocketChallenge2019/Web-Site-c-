using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.IoTrash.Models;

namespace Projeto.IoTrash.Controllers
{
    public class RotaController : Controller
    {

        private static IList<Rota> _lista = new List<Rota>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Rota rota)
        {
            _lista.Add(rota);
            TempData["mensagem"] = "Cadastrado com Sucesso!!";
            return RedirectToAction("Listar");
        }
    }
}