using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PSIUWeb.Data;
using PSIUWeb.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<appDbContext>(options => 
   options.UseSqlServer(
       builder.Configuration.GetConnectionString("PsiuContext")
       )
   );

builder.Services.AddIdentity<appUser, IdentityRole>(

      options =>

      {
          options.User.RequireUniqueEmail = true;
          options.Password.RequiredLength = 6;
          options.Password.RequireNonAlphanumeric = false;
          options.Password.RequireLowercase = false;
          options.Password.RequireUppercase = false;
          options.Password.RequireDigit = false;
          options.SignIn.RequireConfirmedPhoneNumber = false;
          options.Lockout.MaxFailedAccessAttempts = 5;
          options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

      }

)
.AddEntityFrameworkStores<appDbContext>()
.AddDefaultTokenProviders();

  
        

// Add services to the container.
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
