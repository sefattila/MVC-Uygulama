using _07_MVC_EmployeeEntity.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _07_MVC_EmployeeEntity.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepo _repo;

        public EmployeeController(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
    }
}
