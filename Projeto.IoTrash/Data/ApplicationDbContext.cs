using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto.IoTrash.Models;

namespace Projeto.IoTrash.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Caminhao> Caminhoes { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Lixeira> Lixeiras { get; set; }

        public DbSet<Rota> Rotas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
