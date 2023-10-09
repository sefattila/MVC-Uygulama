namespace _09_API_HospitalProject.Classes
{
    public class Hastane:BaseEntity
    {
        public string HastaneAd { get; set; }
        public string Adres { get; set; }

        public virtual ICollection<Hasta> Hastalar { get; set; }
    }
}
