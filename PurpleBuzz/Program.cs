using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));




var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();


