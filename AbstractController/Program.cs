using AbstractController.Controllers;
using AbstractController.Properties.Models;
using AbstractController.RolesFactory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddTransient<HomeAdminController>();
builder.Services.AddTransient<HomeUserController>();
builder.Services.AddTransient<IRoleFactory, RoleFactory>();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();



builder.Services.AddDbContext<Db>(options=> options.UseSqlite($"Data Source=base.db;"));

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthentication();
app.MapControllers();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action}/{id?}",
        defaults: new {controller="Home", action="Index"});
    
});
app.Run();