using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Projeto.IoTrash.Controllers
{
    public class LixeiraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}