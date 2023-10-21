using AbstractController.Controllers;
using AbstractController.Properties.Models;
using AbstractController.RolesFactory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddTransient<HomeControllerAdmin>();
builder.Services.AddTransient<HomeControllerUser>();
builder.Services.AddTransient<IRoleFactory, RoleFactory>();



builder.Services.AddDbContext<Db>(options=> options.UseSqlite($"Data Source=base.db;"));

var app = builder.Build();
app.UseHttpsRedirection();

app.UseRouting();
app.MapControllers();
app.UseEndpoints(endpoints =>
{
 
    
    
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action}/{id?}");
});
app.MapGet("/", () => "Hello World!");

app.Run();