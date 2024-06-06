using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_CodeFirstApproach.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name ="Employee Name")]
        public String Name { get; set; }
        [Display(Name = "Employee Address")]
        public String Address { get; set; }
        [Display(Name ="Employee Salary")]
        public String Salary { get; set; }
    }
}