using System.ComponentModel;

namespace _05_MVC_SinifOgrenci.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DisplayName("Classroom")]
        public int ClassId { get; set; }
    }
}
