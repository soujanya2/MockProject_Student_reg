using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MockProject1.Models
{
    public class MinimumAge:ValidationAttribute
    {
        int minimumage;
        public MinimumAge(int _minimumAge)
        {
            minimumage = _minimumAge;
            ErrorMessage = "Minimum age must be 18 years";
        }
        public override bool IsValid(object? value)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(minimumage) < DateTime.Now;
            }
            return false;
        }
        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString);
        }
    }
}
