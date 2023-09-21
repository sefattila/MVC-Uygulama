using _02_MVC_VeriTransferi.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_MVC_VeriTransferi.Controllers
{
    public class PersonController : Controller
    {
        //bir action tetikliyosak default olarak get tetiklenir
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //Request Form
        //[HttpPost]
        //public IActionResult Index(string? str)
        //{
        //    int id = Convert.ToInt32(Request.Form["pId"]);
        //    string ad = Request.Form["ad"];
        //    string soyad = Request.Form["soyad"];
        //    return View();
        //}

        //Action Parametreleri ile (Name'ler)
        //[HttpPost]
        //public IActionResult Index(int pId,string ad,string soyad)
        //{
        //    int id = pId;
        //    string isim = ad;
        //    string soyIsim=soyad;
        //    return View();
        //}

        //IFormCollection
        //[HttpPost]
        //public IActionResult Index(IFormCollection form)
        //{
        //    int id = int.Parse(form["pId"]);
        //    string ad = form["ad"];
        //    string soyad = form["soyad"];
        //    return View();
        //}

        //Model ile (En çok tercih edilen)
        //[HttpPost]
        //public IActionResult Index(Person person)
        //{

        //    return View();
        //}

        //QueryString İle
        [HttpGet]
        public IActionResult Post()
        {
            string str = Request.QueryString.ToString();
            return View();
        }

    }
}
