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
        [Required]
        public String Name { get; set; }
        [Required]
        public String Address { get; set; }
        public int Age { get; set; }
        [Required]
        public String Email { get; set; }
    }
}