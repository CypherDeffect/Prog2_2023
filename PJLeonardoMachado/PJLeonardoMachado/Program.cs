using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PJLeonardoMachado.Data;
using PJLeonardoMachado.Models;
using System;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<appDbContext>(options =>
   options.UseSqlServer(
       builder.Configuration.GetConnectionString("PsiuContext")
       )
   );

//builder.Services.AddIdentity<Psico, IdentityRole>(
    
    
   options =>
   {
       options.User.RequireUniqueEmail = true;
   }
)
.AddEntityFrameworkStores<appDbContext>()
.AddDefaultTokenProviders();


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();