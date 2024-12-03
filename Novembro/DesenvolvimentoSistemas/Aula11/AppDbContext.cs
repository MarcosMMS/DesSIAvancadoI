using Microsoft.EntityFrameworkCore;
using Aula11.Models;

public class AppDbContext : DbContext{
    public DbSet<Cliente> Cliente {get; set;}
    public DbSet<Livro> Livro {get; set;}
    public DbSet<Venda> Vendas {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
        optionBuilder.UseSqlite(" Data Source=vendas.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Vendas>()
            .HasMany(v=> v.Livros)
            .WitchMany()
            .UsingEntity(j => j.ToTable("VendaLivros"));

            base.OnModelCreating(modelBuilder);
    }

 
}