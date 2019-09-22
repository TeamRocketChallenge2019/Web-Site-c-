﻿using Microsoft.AspNetCore.Mvc;
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
        [Display(Name = "Dia da Semana")]
        public DiaSemana DiaDaSemana{get; set;}
        

    }
} 
