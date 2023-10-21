using AbstractController.RolesFactory;
using Microsoft.AspNetCore.Mvc;

namespace AbstractController.Controllers;

public class HomeController : Controller
{
    private readonly HomeBaseController _homeControllerBase;

    public HomeController(IRoleFactory roleFactory)
    {
        _homeControllerBase = roleFactory.CreateController("admin"); // admin or user
    }

    public ActionResult Index()
    {
        return _homeControllerBase.Index();
    }
}