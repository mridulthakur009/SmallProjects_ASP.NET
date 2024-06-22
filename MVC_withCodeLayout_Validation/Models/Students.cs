using MVC_withCodeLayout_Validation.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_withCodeLayout_Validation.Models
{
    public class Students
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Can't be Empty !!!")]
        public String Name { get; set; }
        [Required(ErrorMessage ="Address Can't be empty")]
        public String Address { get; set; }
       // [Range(18,25,ErrorMessage ="Age should be b/w 18 to 25")]
        [AgeValidation]
        public int? Age { get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }
    }
}