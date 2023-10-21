using AbstractController.Properties.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace AbstractController.Properties.Models;

public class Db : DbContext
{
    public DbSet<User> Users { get; set; }

    public Db(DbContextOptions options):base(options)
    {
        var result = Database.EnsureCreated();
    }
}