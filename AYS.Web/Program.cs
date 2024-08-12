using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AYS.Business.Abstract;
using AYS.Business.Concrete;
using AYS.Data;




var builder = WebApplication.CreateBuilder(args); // Uygulamanýn yapýlandýrmasýný baþlatýr.

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews(); // MVC yapýsýný ekler.

builder.Services.AddScoped<IDeviceService, DeviceService>();
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build(); // Uygulamayý oluþturur.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting(); // Routing iþlemlerini yapýlandýrýr.

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(  // Varsayýlan MVC route'larýný ayarlar
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Uygulamayý baþlatýr.