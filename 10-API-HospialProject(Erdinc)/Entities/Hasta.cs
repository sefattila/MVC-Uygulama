namespace _10_API_HospialProject_Erdinc_.Entities
{
    public class Hasta
    {
        public string Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Klinik { get; set; }
        public DateTime MuayeneTarihi { get; set; }
        public int HastaneId { get; set; }

        public Hastane Hastane { get; set; }
    }
}
