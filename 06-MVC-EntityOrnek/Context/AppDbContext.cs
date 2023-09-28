using _06_MVC_EntityOrnek.Entities;
using Microsoft.EntityFrameworkCore;

namespace _06_MVC_EntityOrnek.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
