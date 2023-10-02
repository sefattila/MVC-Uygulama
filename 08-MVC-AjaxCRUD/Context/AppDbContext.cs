using _08_MVC_AjaxCRUD.Entities;
using Microsoft.EntityFrameworkCore;

namespace _08_MVC_AjaxCRUD.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
