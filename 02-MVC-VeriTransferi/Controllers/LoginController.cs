using _02_MVC_VeriTransferi.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_MVC_VeriTransferi.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(Account account)
        {
            string userName = "sefattila";
            string password = "123456";
            if (account.UserName != userName || account.Password != password)
            {
                ViewBag.Giris = "Hata";
                return View("Login");
            }
            else
            {
                return View("Sucsess");
            }
        }
    }
}
