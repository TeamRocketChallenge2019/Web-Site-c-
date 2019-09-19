using Microsoft.EntityFrameworkCore;
using Projeto.IoTrash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Persistence
{
    public class IoTrashContext : DbContext
    {
        public DbSet<Caminhao> Caminhoes { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Lixeira> Lixeiras { get; set; }

        public DbSet<Rota> Rotas { get; set; }

        public IoTrashContext(DbContextOptions op) : base (op)
        {

        }
    }
}
