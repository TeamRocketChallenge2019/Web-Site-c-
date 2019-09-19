using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    public class Lixeira
    {
        public int LixeiraId;

        public string DescricaoLixeira { get; set; }

        public string VolumeLixo { get; set; }

        public string Endereco { get; set; }

    }
}
