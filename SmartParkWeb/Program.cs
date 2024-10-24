using Microsoft.EntityFrameworkCore;
using SmartParkWeb.DataAccess.Persistence;
using SmartParkWeb.DataAccess.Persistence.Interfaces;
using SmartParkWeb.DataAccess.SmartParkingContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var stringConnection = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<SmartParkContext>
    (
        options => options.UseMySql(stringConnection, ServerVersion.AutoDetect(stringConnection))
    );
builder.Services.AddScoped<IGenericPersist, GenericPersist>();
builder.Services.AddScoped<IIDdriverPersist, DdriverPersist>();
builder.Services.AddScoped<IMilitaryPersist, MilitaryPersist>();
builder.Services.AddScoped<IVehiclePersist, VehiclePersist>();

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
    pattern: "{area=User}/{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
