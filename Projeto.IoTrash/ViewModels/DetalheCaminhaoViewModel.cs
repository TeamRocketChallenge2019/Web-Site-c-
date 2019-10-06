using Projeto.IoTrash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.ViewModels
{
    public class DetalheCaminhaoViewModel
    {

        public Caminhao Caminhao { get; set; }

        public IList<Rota> Rotas { get; set; }
    }
}
