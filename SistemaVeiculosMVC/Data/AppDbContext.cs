using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVeiculosMVC.Models;

namespace SistemaVeiculosMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //direciona a classe (Funcionario) para a tabela funcionario
        public DbSet<Veiculo> TabelaVeiculo { get; set; }

        //sobrescrever o mapeamento do modelo (uma unica tabela para funcionários)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
            .HasDiscriminator<string>("veiculo")
            .HasValue<Carro>("Carro")
            .HasValue<Moto>("Moto");
        }
    }
}