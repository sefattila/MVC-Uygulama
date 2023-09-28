using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace _06_MVC_Validation.ValidationClasses
{
    public class PasswordValidation:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            bool upperCase = value.ToString().Count(char.IsUpper) > 1 ? true : false;
            bool lowerCase = value.ToString().Count(char.IsLower) > 2 ? true : false;
            bool specialCharCount = Regex.Matches(value.ToString(), "[!:+*]").Count > 1 ? true : false;
            if (upperCase && lowerCase && specialCharCount && value.ToString().Length > 8 && value.ToString().Length<16)
            {
                return true;
            }
            return false;
        }
    }
}
