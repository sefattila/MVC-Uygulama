using _03_MVC_CRUD.Models;
using _03_MVC_CRUD.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _03_MVC_CRUD.Controllers
{
    public class UrunController : Controller
    {

        public IActionResult Index(string? search)
        {
            List<Urun> uruns;
            if (search != null)
            {
                uruns = Data.Urunler.Where(x => x.UrunAdi.ToLower().Contains(search) || x.Marka.ToLower().Contains(search)).ToList();
                return View(uruns);
            }
            uruns = Data.Urunler.OrderBy(x => x.Id).ToList();
            return View(uruns);
        }

        //[HttpPost]
        //public IActionResult Index(List<Urun> uruns)
        //{
        //    return View(uruns);
        //}

        public IActionResult UrunEkle()
        {
            ViewBag.Kategori = Data.Kategoriler;
            return View();
        }
        [HttpPost]
        public IActionResult UrunEkle(Urun urun)
        {
            Data.Urunler.Add(urun);
            //return View("View"); //bu direk sayfaya gider. Sayfanın içerisine girer
            return RedirectToAction("Index"); //yukardaki actionu tetikler
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Kategori = Data.Kategoriler;
            Urun urun = Data.Urunler.FirstOrDefault(x => x.Id == id);
            return View(urun);
        }

        [HttpPost]
        public IActionResult Update(Urun urun)
        {
            Urun eskiUrun = Data.Urunler.FirstOrDefault(x => x.Id == urun.Id);
            if (eskiUrun != null)
            {
                Data.Urunler.Remove(eskiUrun);

                eskiUrun.Marka = urun.Marka;
                eskiUrun.UrunAdi = urun.UrunAdi;
                eskiUrun.Fiyat = urun.Fiyat;
                eskiUrun.KategoriId = urun.KategoriId;
                Data.Urunler.Add(eskiUrun);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Urun urunSil = Data.Urunler.FirstOrDefault(x => x.Id == id);

            if (urunSil != null)
            {
                Data.Urunler.Remove(urunSil);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
