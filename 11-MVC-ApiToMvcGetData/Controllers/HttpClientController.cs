using _11_MVC_ApiToMvcGetData.Views.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _11_MVC_ApiToMvcGetData.Controllers
{
    public class HttpClientController : Controller
    {
        HttpClient client;
        private string apiAdress = "https://localhost:7014/api/Hastane/";

        public HttpClientController()
        {
            client = new HttpClient();
        }

        public IActionResult Index()
        {
            List<HastaneListVM> hastanes = client.GetFromJsonAsync<List<HastaneListVM>>(apiAdress + "GetAll").Result;
            if (hastanes is not null)
                return View();

            ViewData["info"] = "Görüntülenecek Hastane Yok";
            return View("Index", "Home");
        }

        public IActionResult GetById(int id)
        {
            HastaneListVM hastane = client.GetFromJsonAsync<HastaneListVM>(apiAdress + "Get/" + id).Result;
            return View(hastane);
        }

        public IActionResult Create(HastaneCreateVM hastane)
        {
            hastane.HastaneAd = "Özel";
            hastane.Adres = "Kastamonu";
            var result = client.PostAsJsonAsync(apiAdress + "Create", hastane).Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Update(HastaneListVM hastaneListVM)
        {
            hastaneListVM.Id = 2;
            hastaneListVM.HastaneAd = "Güncel";
            hastaneListVM.Adres = "Güncel";

            var result = client.PutAsJsonAsync(apiAdress + "Update", hastaneListVM).Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var result = client.DeleteAsync(apiAdress + "Delete/" + id).Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
