namespace _07_MVC_EmployeeEntity.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
