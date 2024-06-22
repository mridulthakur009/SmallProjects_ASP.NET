using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_withCodeLayout_Validation.CustomValidation
{
    public class AgeValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int age = Convert.ToInt32(value);
            if (age >= 18)
                return ValidationResult.Success;
            else
                return new ValidationResult("Age must be greater than 18");
        }
    }
}