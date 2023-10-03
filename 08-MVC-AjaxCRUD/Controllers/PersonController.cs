using _08_MVC_AjaxCRUD.Context;
using _08_MVC_AjaxCRUD.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _08_MVC_AjaxCRUD.Controllers
{
    public class PersonController : Controller
    {
        private readonly AppDbContext _dbContext;

        public PersonController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetPeople()
        {
            List<Person> people = _dbContext.People.ToList();
            return PartialView("_PeoplePartial", people);
        }
        public IActionResult Create()
        {
            return PartialView("_CreatePartial");
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            _dbContext.People.Add(person);
            bool isAdded = _dbContext.SaveChanges() > 0;
            if (isAdded)
            {
                return Json("ok");
            }
            return Json("fail");
        }

        public IActionResult Update(int id)
        {
            return PartialView("_UpdatePartial",_dbContext.People.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Person person)
        {
            _dbContext.People.Update(person);
            if (_dbContext.SaveChanges() > 0)
            {
                return Json("ok");
            }
            return Json("fail");
        }

        public IActionResult Delete(int id)
        {
            _dbContext.People.Remove(_dbContext.People.Find(id));
            if (_dbContext.SaveChanges() > 0)
            {
                return Json("ok");
            }
            return Json("fail");
        }

    }
}
