using AbstractController.Properties.Models.UserModels.DTO;

namespace AbstractController.Properties.Models.UserModels;

public static class UserMapper
{
    public static CreateUserDto GetCreateUserDto(this UserModels.User user)
    {
        return new CreateUserDto
        {
            Name = user.Name
        };
    }
}