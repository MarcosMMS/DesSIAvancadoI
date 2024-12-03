using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option){}

    public DbSet<Pessoa> Pessoas { get; set; }
}
