using _09_API_HospitalProject.Classes;
using _09_API_HospitalProject.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _09_API_HospitalProject.Repositories.Concretes
{
    public class HastaRepo : BaseRepo<Hasta>
    {
        public HastaRepo(AppDbContext context, DbSet<Hasta> table) : base(context, table)
        {
        }
    }
}
