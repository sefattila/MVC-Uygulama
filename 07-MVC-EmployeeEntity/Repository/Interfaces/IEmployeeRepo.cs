using _07_MVC_EmployeeEntity.Entities;

namespace _07_MVC_EmployeeEntity.Repository.Interfaces
{
    public interface IEmployeeRepo
    {
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        Employee GetEmployee(int id);
        IList<Employee> GetAll();
    }
}
