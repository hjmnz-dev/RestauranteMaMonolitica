using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.DbObjects;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Repositores;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RestauranteContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RestauranteContext")));

// Registrar todas las dependencias necesarias
builder.Services.AddScoped<IMenuRepositories, MenuDb>();
builder.Services.AddScoped<MenuRepositories>(); // Registro de MenuRepositories

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
