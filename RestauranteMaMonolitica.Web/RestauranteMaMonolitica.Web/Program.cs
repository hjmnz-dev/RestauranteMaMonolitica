using Microsoft.EntityFrameworkCore;
using RestauranteMaMonolitica.Web.BL.Interfaces;
using RestauranteMaMonolitica.Web.BL.Services;
using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.DbObjects;
using RestauranteMaMonolitica.Web.Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RestauranteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestauranteContext"))); 

builder.Services.AddScoped<IFacturaDb, FacturaDb>();

builder.Services.AddTransient<IFacturaService, FacturaService>();

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
