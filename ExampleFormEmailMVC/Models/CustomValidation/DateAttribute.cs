using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;

namespace ExampleFormEmailMVC.Models.CustomValidation
{
    public class DateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime result;
            var valueString = Convert.ToString(value).Replace("-",string.Empty);
            var errorMessage = FormatErrorMessage(validationContext.DisplayName);

            if (!string.IsNullOrEmpty(valueString))
            {
               return !DateTime.TryParse(valueString, out result) == true ? ValidationResult.Success : new ValidationResult(errorMessage);
            }

            return ValidationResult.Success;
        }
    }
}