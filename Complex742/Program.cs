using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Complex742.Data;
using Complex742.Models.Equipments;


var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders().AddConsole();

  builder.Services.AddDbContext<Complex742Context>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Complex742Context")));
builder.Services.AddTransient<IRepository<Equipment>, DbEquipmentRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(name:"equipment", pattern: "{Controller=Equipment}/{action=Index}/{id?}");

app.Run();
