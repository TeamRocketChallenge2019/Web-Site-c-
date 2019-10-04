using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    [Table("TbRota")]
    public class Rota
    {
        [Column("Id"), HiddenInput]
        public int RotaId { get; set; }

        [Required]
        public string DescricaoRota { get; set; }

        [Required]
        [Display(Name = "Dia da Semana")]
        public DiaSemana DiaDaSemana { get; set; }


        public IList<Lixeira> Lixeiras { get; set; }

        public Caminhao Caminhao { get; set; }
        public int CaminhaoId { get; set; }
    }
}
