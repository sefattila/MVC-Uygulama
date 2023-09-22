using _03_MVC_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_MVC_CRUD.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}