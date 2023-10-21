using AbstractController.Controllers;

namespace AbstractController.RolesFactory;

public interface IRoleFactory
{
    HomeControllerBase CreateController(string role);
}

public class RoleFactory : IRoleFactory
{
    private readonly IServiceProvider _serviceProvider;

    public RoleFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public HomeControllerBase CreateController(string role)
    {
        return role switch
        {
            "admin" => _serviceProvider.GetService<HomeControllerAdmin>(),
            "user" => _serviceProvider.GetService<HomeControllerUser>()
        };
    }
}