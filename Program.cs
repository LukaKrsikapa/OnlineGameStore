using Microsoft.EntityFrameworkCore;
using ZavrsniRad.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ZavrsniRad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IGenreRepository, GenreRepository>();
            builder.Services.AddScoped<IGameRepository, GameRepository>();
            builder.Services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSession();
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<StoreDbContext>(options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnString"));
                }
            );

            builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<StoreDbContext>().AddDefaultTokenProviders().AddDefaultUI();

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
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}