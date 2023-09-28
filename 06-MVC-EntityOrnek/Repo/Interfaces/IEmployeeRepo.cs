using _06_MVC_EntityOrnek.Entities;

namespace _06_MVC_EntityOrnek.Repo.Interfaces
{
    public interface IEmployeeRepo
    {
        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
        Employee GetEmployee(int id);
        IList<Employee> GetAll();   
    }
}
