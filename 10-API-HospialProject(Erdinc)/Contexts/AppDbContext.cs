using _10_API_HospialProject_Erdinc_.Entities;
using Microsoft.EntityFrameworkCore;

namespace _10_API_HospialProject_Erdinc_.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Hasta> Hastalars { get; set; }
        public DbSet<Hastane> Hastaneler { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
