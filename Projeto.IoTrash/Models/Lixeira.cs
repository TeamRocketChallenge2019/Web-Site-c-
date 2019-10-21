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

        [Required(ErrorMessage = "Descrição Obrigatória")]
        [Display(Name = "Descrição Lixeira")]
        public string DescricaoLixeira { get; set; }

        [Required(ErrorMessage = "Volume Lixo Obrigatório")]
        [Display(Name = "Volume Lixo")]
        public int VolumeLixo { get; set; }

        [Required(ErrorMessage = "Endereço Obrigatório")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }


        public Rota Rota { get; set; }
        public int RotaId { get; set; }
    }
}
