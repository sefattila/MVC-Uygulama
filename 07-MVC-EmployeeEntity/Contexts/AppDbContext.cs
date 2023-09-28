using _07_MVC_EmployeeEntity.Entities;
using _07_MVC_EmployeeEntity.SeedData;
using Microsoft.EntityFrameworkCore;

namespace _07_MVC_EmployeeEntity.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanySD()).ApplyConfiguration(new EmployeeSD());

        }
    }
}
