using _09_API_HospitalProject.Classes;
using _09_API_HospitalProject.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _09_API_HospitalProject.Repositories.Concretes
{
    public class HastaneRepo : BaseRepo<Hastane>
    {
        public HastaneRepo(AppDbContext context, DbSet<Hastane> table) : base(context, table)
        {
        }
    }
}
