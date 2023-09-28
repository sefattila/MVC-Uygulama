using _07_MVC_EmployeeEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _07_MVC_EmployeeEntity.SeedData
{
    public class EmployeeSD : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                    new Employee { Id = 1, FirstName = "Sefa", LastName = "ATTİLA", CompanyId = 1 },
                    new Employee { Id = 2, FirstName = "Ali", LastName = "Gündüz", CompanyId = 2 },
                    new Employee { Id = 3, FirstName = "Mehmet", LastName = "Kısa", CompanyId = 3 },
                    new Employee { Id = 4, FirstName = "Ahmet", LastName = "Yaşar", CompanyId = 1 }
                );
        }
    }
}
