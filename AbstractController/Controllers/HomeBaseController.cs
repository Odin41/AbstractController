using Microsoft.AspNetCore.Mvc;

namespace AbstractController.Controllers;

public abstract class HomeBaseController: Controller
{
    public virtual ActionResult Index()
    {
        return Forbid();
    }
}