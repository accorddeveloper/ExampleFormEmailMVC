using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ExampleFormEmailMVC.Models.CustomValidation;
using System.Linq;
using System.Web;

namespace ExampleFormEmailMVC.Models
{
    public class GenericFormModel //: IValidatableObject
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "{0} is required")]
        public string ExampleName { get; set; }

        [Display(Name = "Address")]
        public string ExampleAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression(@"^\(\d{3}\) ?\d{3}( |-)?\d{4}|^\d{3}( |-)?\d{3}( |-)?\d{4}", ErrorMessage = "xxx-xxx-xxxx")]
        public string ExamplePhoneNumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        //Example of custom written validation annotation see Models/CustomValidation/DateAttribute.cs
        [Date(ErrorMessage = "Not a valid date")]
        public string ExampleDate { get; set; }


        //Example of self-validating model
       /* public IEnumerable<ValidationResult> Validate(ValidationContext context)
        {
            DateTime result;
            if (!DateTime.TryParse(ExampleDate, out result ))
            {
                yield return new ValidationResult("Invalid Date", new[] {"ExampleDate"});
            }
        }*/
    }
}