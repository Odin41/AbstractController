using AbstractController.Properties.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace AbstractController.Controllers;

public class HomeControllerAdmin : HomeControllerBase
{
    private readonly Db _db;

    public HomeControllerAdmin(Db db)
    {
        _db = db;
    }
    public override ActionResult Index()
    {
        var a = _db.Users.Count();
        return View("Index");
    }
}