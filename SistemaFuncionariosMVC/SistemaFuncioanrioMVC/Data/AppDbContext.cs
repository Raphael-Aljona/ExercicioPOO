using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaFuncioanrioMVC.Models;

namespace SistemaFuncioanrioMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //direciona a classe (Funcionario) para a tabela funcionario
        public DbSet<Funcionario> TabelaFuncionario { get; set; }

        //sobrescrever o mapeamento do modelo (uma unica tabela para funcionários)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>()
            .HasDiscriminator<string>("cargo")
            .HasValue<Gerente>("Gerente")
            .HasValue<Vendedor>("Vendedor");
        }
    }
}