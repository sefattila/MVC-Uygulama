using _04_MVC_Layout_Partial_ViewComp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _04_MVC_Layout_Partial_ViewComp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id= 1,
                    Name="Ürün",
                    Price=25000
                },
                new Product
                {
                    Id= 2,
                    Name="Ürün-2",
                    Price=30000
                }
            };
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}