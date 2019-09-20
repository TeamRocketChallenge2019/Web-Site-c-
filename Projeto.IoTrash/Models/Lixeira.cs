using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    [Table("TbLixeira")]
    public class Lixeira
    {
        [Column("Id"), HiddenInput]
        public int LixeiraId { get; set; }

        [Required]
        public string DescricaoLixeira { get; set; }

        [Required]
        public string VolumeLixo { get; set; }

        [Required]
        public string Endereco { get; set; }

    }
}
