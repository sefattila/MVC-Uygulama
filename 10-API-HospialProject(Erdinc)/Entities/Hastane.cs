﻿namespace _10_API_HospialProject_Erdinc_.Entities
{
    public class Hastane
    {
        public int Id { get; set; }
        public string HastaneAd { get; set; }
        public string Adres { get; set; }

        public IList<Hasta> Hastalar { get; set; }
    }
}
