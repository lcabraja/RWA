using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadatak01.Models.CustomValidators
{
    public class ImeValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int maxznakova = 10;
            var kupac = validationContext.ObjectInstance as Kupac;
            if (kupac.Ime == null)
            {
                return ValidationResult.Success;
            }
            return kupac.Ime.Length <= maxznakova ? ValidationResult.Success : new ValidationResult($"Tvoje ime ima {kupac.Ime.Length} znakova, a najvise smije imati {maxznakova}");
        }
    }
}