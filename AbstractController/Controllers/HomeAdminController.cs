using AbstractController.Properties.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace AbstractController.Controllers;

public class HomeAdminController : HomeBaseController
{
    private readonly Db _db;

    public HomeAdminController(Db db)
    {
        _db = db;
    }
    public override ActionResult Index()
    {
        var a = _db.Users.Count();
        return View("HomeBase/Index");
    }
}