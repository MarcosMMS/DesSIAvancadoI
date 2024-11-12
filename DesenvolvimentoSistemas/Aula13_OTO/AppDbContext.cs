using Microsoft.EntityFrameworkCore;

namespace Aula13_OTO{
    public class AppDbContext : DbContext{
        public DbSet<Pessoa> Pessoas { get; set; } = null;
        public DbSet<Endereco> Enderecos { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=relacionamento.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Pessoa>()
            .HasOne(p => p.Endereco)
            .WithOne(e => e.Pessoa)
            .HasForeignKey<Endereco>(e => e.PessoaId);
        }

    }
}