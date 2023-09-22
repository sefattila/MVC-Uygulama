using _03_MVC_CRUD.Models;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace _03_MVC_CRUD.Repository
{
    public static class Data
    {
        public static List<Urun> Urunler = new List<Urun>()
        {
            new Urun()
            {
                Id= 1,
                Marka="Asus",
                UrunAdi="Rog",
                Fiyat=25000,
                KategoriId=1
            },
            new Urun()
            {
                Id= 2,
                Marka="Monster",
                UrunAdi="Tulpar",
                Fiyat=30000,
                KategoriId=1
            },
            new Urun()
            {
                Id= 3,
                Marka="Steel Series",
                UrunAdi="Rival",
                Fiyat=1500,
                KategoriId=2
            },
            new Urun()
            {
                Id= 5,
                Marka="Iphone",
                UrunAdi="14",
                Fiyat=50000,
                KategoriId=3
            }
        };

        public static List<Kategori> Kategoriler = new List<Kategori>()
        {
            new Kategori()
            {
                Id= 1,
                KategoriAd="Bilgisayar",
                Aciklama="PCPCPCPCPCPCPC"
            },
            new Kategori()
            {
                Id= 2,
                KategoriAd="Aksesuar",
                Aciklama="Mouse ve Kulaklıklar"
            },
            new Kategori()
            {
                Id= 3,
                KategoriAd="Telefon",
                Aciklama="Akıllı Telefon"
            }
        };
    }
}
