using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    [Table("TbCaminhao")]
    public class Caminhao
    {

        [Column("Id"), HiddenInput]
        public int CaminhaoId { get; set; }


        [Required]
        public string Placa { get; set; }

        [Required]
        public double QuantidadeLixo { get; set; }


        public Empresa Empresa { get; set; }

        public int EmpresaId { get; set; }

        public IList<Rota> Rotas { get; set; }
    }
}
