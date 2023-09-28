using _07_MVC_EmployeeEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _07_MVC_EmployeeEntity.SeedData
{
    public class CompanySD : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                    new Company { Id = 1, Brand = "Apple", Name = "Apple", Address = "USA" },
                    new Company { Id = 2, Brand = "Nvidia", Name = "Nvidia", Address = "USA" },
                    new Company { Id = 3, Brand = "Nissan", Name = "Nissan", Address = "Japan" }
                );
        }
    }
}
