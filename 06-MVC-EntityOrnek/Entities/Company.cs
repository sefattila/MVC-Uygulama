namespace _06_MVC_EntityOrnek.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public IList<Employee> Employees { get; set; }
    }
}
