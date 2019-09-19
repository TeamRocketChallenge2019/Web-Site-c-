﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    public class Empresa
    {
        public string CNPJ { get; set; }

        [Display(Name="Razão Social")]
        public string RazaoSocial { get; set; }

        public int Telefone { get; set; }

        public string Email { get; set; }
    }
}
