namespace _03_MVC_CRUD.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int KategoriId { get; set; }
    }
}
