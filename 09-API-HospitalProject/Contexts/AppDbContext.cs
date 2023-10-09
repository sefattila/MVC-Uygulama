using _09_API_HospitalProject.Classes;
using Microsoft.EntityFrameworkCore;

namespace _09_API_HospitalProject.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Hastane> Hastaneler { get; set; }
        public DbSet<Hasta> Hastalar { get; set; }


    }
}
