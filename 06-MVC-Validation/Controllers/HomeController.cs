using _06_MVC_Validation.Classes;
using _06_MVC_Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _06_MVC_Validation.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SystemUser systemUser)
        {
            if (!ModelState.IsValid) //server side
                return View();
            //Data.SystemUser.Add(employee)
            return RedirectToAction("Index");
        }
    }
}