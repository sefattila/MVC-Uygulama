using _01_MVC_Uygulama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01_MVC_Uygulama.Controllers
{
    public class HomeController : Controller
    {
        //action 
        public IActionResult Index()
        {
            return View();
        }
        //action
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Attila()
        {
            return View();
        }
    }
}