using Projeto.IoTrash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.ViewModels
{
    public class DetalheRotaViewModel
    {

        public Rota Rota { get; set; }

        public IList<Lixeira> Lixeiras { get; set; }

    }
}
