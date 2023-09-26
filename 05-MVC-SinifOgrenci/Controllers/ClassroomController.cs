using _05_MVC_SinifOgrenci.Models;
using _05_MVC_SinifOgrenci.Models.VMs;
using _05_MVC_SinifOgrenci.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _05_MVC_SinifOgrenci.Controllers
{
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.classrooms);
        }

        public IActionResult StudentList(int id)
        {
            List<Student> student = Data.students.Where(x => x.ClassId == id).ToList();
            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Classroom classroom)
        {
            Data.classrooms.Add(classroom);
            return RedirectToAction("Index");
        }
    }
}
