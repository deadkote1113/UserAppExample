using Microsoft.EntityFrameworkCore;
using UserApp.Repository;
using UserApp.Repository.Models;

namespace UserApp.Services;

public class UsersService
{
    private readonly PostgresDbContext _context;

    public UsersService(PostgresDbContext context)
    {
        _context = context;
    }

    public Task<User> GetAsync(int id)
    {
        return _context.Users.FirstAsync(val => val.Id == id);
    }

    public async Task<int> CreateAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user.Id;
    }

    public async Task UpdateAsync(User user)
    {
        var dbUser = await GetAsync(user.Id);
        dbUser.Name = user.Name;
        dbUser.LastName = user.LastName;
        dbUser.Patronymic = user.Patronymic;
        dbUser.Sex = user.Sex;
        dbUser.AvatarLink = user.AvatarLink;
        dbUser.BirthDate = user.BirthDate;
        dbUser.AboutMe = user.AboutMe;
        dbUser.IsBanned = user.IsBanned;
        await _context.SaveChangesAsync();
        return;
    }

    public async Task DeleteAsync(int id)
    {
        var user = await GetAsync(id);
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}
