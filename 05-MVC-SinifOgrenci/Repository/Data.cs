using _05_MVC_SinifOgrenci.Models;

namespace _05_MVC_SinifOgrenci.Repository
{
    public static class Data
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(){Id=1,FirstName="Sefa",LastName="ATTİLA",ClassId=1},
            new Student(){Id=2,FirstName="Ahmet",LastName="Yaşar",ClassId = 1},
            new Student(){Id=3,FirstName="Yunus",LastName="Ünal", ClassId = 2},
            new Student(){Id=4,FirstName="Yusuf",LastName="Demir",ClassId=3}
        };

        public static List<Classroom> classrooms = new List<Classroom>()
        {
            new Classroom(){Id=1,Name="C#"},
            new Classroom(){Id=2,Name="C"},
            new Classroom(){Id=3,Name="C++"},
            new Classroom(){Id=4,Name="Dart"},
            new Classroom(){Id=5,Name="Java"},
        };
    }
}
