using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    public class Lixeira
    {
        public int LixeiraId;

        [Required]
        public string DescricaoLixeira { get; set; }

        [Required]
        public string VolumeLixo { get; set; }

        [Required]
        public string Endereco { get; set; }

    }
}
