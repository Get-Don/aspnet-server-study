using ApiServer.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiServer.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Weapon> Weapons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>()
        .Property(e => e.CreatedDate)
        .HasDefaultValueSql("GETDATE()");
    }
}
