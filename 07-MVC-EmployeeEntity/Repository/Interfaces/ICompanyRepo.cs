using _07_MVC_EmployeeEntity.Entities;

namespace _07_MVC_EmployeeEntity.Repository.Interfaces
{
    public interface ICompanyRepo
    {
        void Add(Company company);
        void Update(Company company);
        void Delete(Company company);
        Company GetCompany(int id);
        IList<Company> GetAll();    
    }
}
