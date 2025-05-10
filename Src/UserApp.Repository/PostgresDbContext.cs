using Microsoft.EntityFrameworkCore;
using UserApp.Domain;
using UserApp.Repository.Models;

namespace UserApp.Repository;

public class PostgresDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
    {
        Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User(1, "Gleb", "Lapkin", "Igorevich", Gender.Male,"placeholder.png", new DateTime(2002, 9, 17), "", false));
    }
}
