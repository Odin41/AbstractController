using AbstractController.Controllers;

namespace AbstractController.RolesFactory;

public interface IRoleFactory
{
    HomeBaseController CreateController(string role);
}

public class RoleFactory : IRoleFactory
{
    private readonly IServiceProvider _serviceProvider;

    public RoleFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public HomeBaseController CreateController(string role)
    {
        return role switch
        {
            "admin" => _serviceProvider.GetService<HomeAdminController>(),
            "user" => _serviceProvider.GetService<HomeUserController>()
        };
    }
}