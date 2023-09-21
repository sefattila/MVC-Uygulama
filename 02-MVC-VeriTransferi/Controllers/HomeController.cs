using _02_MVC_VeriTransferi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _02_MVC_VeriTransferi.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewData["mesaj"] = "Merhaba Dünya"; //
            ViewBag.Message = "Merhaba Türkiye"; //dinamik

            Person person = new Person()
            {
                PersonId = 1,
                Ad = "Sefa",
                Soyad = "ATTİLA"
            };

            ViewData["per1"]=person;
            ViewBag.Per2=person;

            List<Person> people = new List<Person>()
            {
                new Person()
                {
                    PersonId=2,
                    Ad="Queen Naime",
                    Soyad="Damataşı"
                },
                new Person()
                {
                    PersonId=3,
                    Ad="İrem",
                    Soyad="Büyükbektaş"
                },
                new Person()
                {
                    PersonId=1903,
                    Ad="Alperen",
                    Soyad="Çiçek"
                }
            };

            ViewData["personList"] = people;
            ViewBag.persons=people;

            TempData["data"] = "Sefa Attila Bilge Adam";

            return View();
        }

        public IActionResult Data()
        {
            //string viewData = ViewData["mesaj"].ToString(); //nullreferansexeption
            string str = TempData["data"].ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}