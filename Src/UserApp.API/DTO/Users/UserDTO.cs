using UserApp.Domain;

namespace UserApp.API.DTO.Users;

public class UserDTO
{
    public UserDTO(int id, string name, string lastName, string? patronymic, Gender sex,
        string avatarLink, DateTime birthDate, string aboutMe, bool isBanned)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Patronymic = patronymic;
        Sex = sex;
        AvatarLink = avatarLink;
        BirthDate = birthDate;
        AboutMe = aboutMe;
        IsBanned = isBanned;
    }

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
