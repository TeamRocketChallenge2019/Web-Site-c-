using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    [Table("TbEmpresa")]
    public class Empresa
    {
        [Column("Id"), HiddenInput]
        public int EmpresaId { get; set; }

        [Required(ErrorMessage = "CNPJ obrigatório")]
        public string CNPJ { get; set; }

        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "Razão Social Obrigatória")]
        public string RazaoSocial { get; set; }

        [Phone]
        [Required(ErrorMessage = "Telefone obrigatório")]
        public string Telefone { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email obrigatório")]
        public string Email { get; set; }

        public IList<Caminhao> Caminhoes { get; set; }
    }
}
