using _09_API_HospitalProject.Classes;

namespace _09_API_HospitalProject.Repositories.Interfaces
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
    }
}
