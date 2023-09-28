using System.ComponentModel.DataAnnotations;

namespace _06_MVC_Validation.Models.ModelMetaDatas
{
    public class UserMetaData
    {
        [Required(ErrorMessage = "Boş Geçilemez")]
        [StringLength(50, ErrorMessage = "3-50 Arası olmalı", MinimumLength = 3)]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "3-50 Arası olmalı", MinimumLength = 3)]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string LastName { get; set; }

        [Range(18, 100, ErrorMessage = "18-100 Arası olmalı")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Yanlış format")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string Email { get; set; }

        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string Password { get; set; }
    }
}
