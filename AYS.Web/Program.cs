using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AYS.Business.Abstract;
using AYS.Business.Concrete;
using AYS.Data;




var builder = WebApplication.CreateBuilder(args); // Uygulamanın yapılandırmasını başlatır.

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews(); // MVC yapısını ekler.

builder.Services.AddScoped<IDeviceService, DeviceService>();
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build(); // Uygulamayı oluşturur.

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

app.UseRouting(); // Routing işlemlerini yapılandırır.

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(  // Varsayılan MVC route'larını ayarlar
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Uygulamayı başlatır.