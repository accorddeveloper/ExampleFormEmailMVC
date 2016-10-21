using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ExampleFormEmailMVC.Models
{
    public class GenericFormModel
    {
        [Required(ErrorMessage = "Field is required")]
        public string ExampleName { get; set; }
        public string ExampleAddress { get; set; }
        public string ExamplePhoneNumber { get; set; }
        public string ExampleDate { get; set; }
    }
}