using AtividadePOO.Models;
using Microsoft.EntityFrameworkCore;

namespace AtividadePOO
{
    public class DataContext : DbContext
    {
        public DbSet<Conta> Conta{get;set;}
        public DbSet<ContaConrrente> ContaCorrente{get;set;}
        public DbSet<ContaPoupanca> ContaPoupanca{get;set;}
        public DbSet<ContaTitular> ContaTitular{get;set;}
        public DbSet<Agencia> Agencia { get; set; }
        
        public DbSet<Banco> Bancos { get; set; }
        
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=lp2; User Id=gl; Password=atividade;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //Chaves compostas(passando o id da conta e o id do titual)
            modelBuilder.Entity<ContaTitular>().HasKey(conta => new { conta.ContaId, conta.TitularId});

            //Chaves unicas(Passando o numero e o cpc do titular da conta)
            modelBuilder.Entity<Conta>().HasIndex(c => c.Numero).IsUnique(true);
            modelBuilder.Entity<Titular>().HasIndex(t => t.Cpf).IsUnique(true);
        }

    }
}