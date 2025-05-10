using UserApp.Repository.Models;

namespace UserApp.API.DTO.Users;

public static class UserMapperExtensions
{
    public static User ToEntity(this UserCreateDTO user)
    {
        return new User(0, user.Name, user.LastName, user.Patronymic, user.Sex,
            user.AvatarLink, user.BirthDate, user.AboutMe, user.IsBanned);
    }

    public static User ToEntity(this UserDTO user)
    {
        return new User(user.Id, user.Name, user.LastName, user.Patronymic, user.Sex,
            user.AvatarLink, user.BirthDate, user.AboutMe, user.IsBanned);
    }

    public static UserDTO ToDTO(this User user)
    {
        return new UserDTO(user.Id, user.Name, user.LastName, user.Patronymic, user.Sex,
            user.AvatarLink, user.BirthDate, user.AboutMe, user.IsBanned);
    }
}
