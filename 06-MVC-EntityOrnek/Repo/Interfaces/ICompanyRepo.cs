using _06_MVC_EntityOrnek.Entities;

namespace _06_MVC_EntityOrnek.Repo.Interfaces
{
    public interface ICompanyRepo
    {
        void Add(Company company);
        void Delete(Company company);
        void Update(Company company);
        Company GetCompany(int id);
        IList<Company> GetAll();
    }
}
