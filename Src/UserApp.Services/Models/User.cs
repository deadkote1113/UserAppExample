using UserApp.Domain;

namespace UserApp.Services.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string? Patronymic { get; set; }
    public Gender Sex { get; set; }
    public string AvatarLink { get; set; }
    public DateTime BirthDate { get; set; }
    public string AboutMe { get; set; }
    public bool IsBanned { get; set; }
}
