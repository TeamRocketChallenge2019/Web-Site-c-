using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Models
{
    public class Rota
    {
        public int RotaId;

        [DataType(DataType.Date)]
        [Required]
        public DayOfWeek Data{get; set;}
        

    }
}
