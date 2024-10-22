using Microsoft.EntityFrameworkCore;

namespace Aula13_OTM 
{
    
    public class AppDbContext : DbContext {
        public DbSet<Categoria> Categorias { get; set; } = null;
        public DbSet<Produto> Produtos { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=relacionamento.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Produto>().HasOne(p => p.Categoria)
            .WithMany(c => c.Produtos)
            .HasForeignKey(p => p.CategoriaId);
        }

    }

}