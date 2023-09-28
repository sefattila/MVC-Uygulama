using _07_MVC_EmployeeEntity.Contexts;
using _07_MVC_EmployeeEntity.Entities;
using _07_MVC_EmployeeEntity.Repository.Interfaces;

namespace _07_MVC_EmployeeEntity.Repository.Concretes
{
    public class CompanyRepo:ICompanyRepo
    {
        private readonly AppDbContext _context;

        public CompanyRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public void Delete(Company company)
        {
            _context.Companies.Remove(company);
            _context.SaveChanges();
        }

        public IList<Company> GetAll()
        {
            return _context.Companies.ToList();
        }

        public Company GetCompany(int id)
        {
            return _context.Companies.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Company company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
        }
    }
}
