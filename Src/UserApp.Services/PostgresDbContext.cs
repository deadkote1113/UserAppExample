using Microsoft.EntityFrameworkCore;
using UserApp.Domain;
using UserApp.Services.Models;

namespace UserApp.Services;

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
            new User()
            {
                Id = 1,
                Name = "Gleb",
                LastName = "Lapkin",
                Patronymic = "Igorevich",
                Sex = Gender.Male,
                AvatarLink = "placeholder.png",
                BirthDate = new DateTime(2002, 9, 17),
                AboutMe = "",
                IsBanned = false,
            });
    }
}
