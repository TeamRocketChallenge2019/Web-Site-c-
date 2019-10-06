using Projeto.IoTrash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.ViewModels
{
    public class DetalheEmpresaViewModel
    {
        public Empresa Empresa { get; set; }
        public IList<Caminhao> Caminhoes { get; set; }
    }
}
