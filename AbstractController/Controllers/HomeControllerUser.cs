using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace AbstractController.Controllers;

public class HomeControllerAdmin : HomeControllerBase
{
    public override ActionResult Index()
    {
        return View("Index");
    }
}