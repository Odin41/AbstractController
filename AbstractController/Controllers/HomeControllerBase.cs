using Microsoft.AspNetCore.Mvc;

namespace AbstractController.Controllers;

public abstract class HomeControllerBase: Controller
{
    public virtual ActionResult Index()
    {
        return Forbid();
    }
}