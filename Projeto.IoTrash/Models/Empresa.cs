using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    public class Empresa
    {
       
        public int EmpresaId;

        [Required]
        public string CNPJ { get; set; }

        [Display (Name = "Razao Social"), MaxLength(40)]
        [Required]
        public string RazaoSocial { get; set; }

        [Phone]
        [Required]
        public string Telefone { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
