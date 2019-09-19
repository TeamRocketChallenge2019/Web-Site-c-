using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    public class Caminhao
    {

        public int CaminhaoId;

        [Required]
        public string Placa { get; set; }

        [Required]
        public double QuantidadeLixo { get; set; }


  }
}
