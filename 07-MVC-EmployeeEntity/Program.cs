using _07_MVC_EmployeeEntity.Contexts;
using _07_MVC_EmployeeEntity.Repository.Concretes;
using _07_MVC_EmployeeEntity.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _07_MVC_EmployeeEntity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddTransient<ICompanyRepo, CompanyRepo>();
            builder.Services.AddTransient<IEmployeeRepo, EmployeeRepo>();

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Server=KDK-403-PC13-YZ;Database=EmployeeDbMVC;Trusted_Connection=True;"));
            
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
        }
    }
}