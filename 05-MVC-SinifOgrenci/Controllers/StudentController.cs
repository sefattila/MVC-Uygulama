using _05_MVC_SinifOgrenci.Models;
using _05_MVC_SinifOgrenci.Models.VMs;
using _05_MVC_SinifOgrenci.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _05_MVC_SinifOgrenci.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.students);
        }

        public IActionResult Create()
        {
            CreateVMs createVMs=new CreateVMs();
            createVMs.Student = new Student();
            createVMs.Classrooms = Data.classrooms;
            return View(createVMs);
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            Data.students.Add(student);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            Student student = Data.students.FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            Student old=Data.students.FirstOrDefault(x=>x.Id== student.Id);
            old.FirstName = student.FirstName;
            old.LastName = student.LastName;
            old.ClassId=student.ClassId;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Student student = Data.students.FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        //[HttpPost]
        //public IActionResult Delete(Student student)
        //{
        //    Data.students.Remove(student);
        //    return RedirectToAction("Index");
        //}

        public IActionResult DeleteStudent(int id)
        {
            Student student = Data.students.FirstOrDefault(x => x.Id == id);
            Data.students.Remove(student);
            return RedirectToAction("Index");
        }
    }
}
