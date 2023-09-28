using _06_MVC_Validation.Models.ModelMetaDatas;
using _06_MVC_Validation.ValidationClasses;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace _06_MVC_Validation.Classes
{
    [ModelMetadataType(typeof(UserMetaData))]
    public class SystemUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
