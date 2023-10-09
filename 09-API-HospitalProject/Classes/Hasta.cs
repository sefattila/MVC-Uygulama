using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace _09_API_HospitalProject.Classes
{
    public class Hasta:BaseEntity
    {
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string Klinik { get; set; }
        public DateTime MuayeneTarihi { get; set; }
        public int HastaneId { get; set; }

        public virtual Hastane Hastane { get; set; }

    }
}
