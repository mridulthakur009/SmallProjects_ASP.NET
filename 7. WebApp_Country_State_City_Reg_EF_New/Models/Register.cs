using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp_Country_State_City_Reg_EF.Models
{
    public class Register
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }
        [Required]
        public GenderType Gender { get; set; }
        public bool Subscribe { get; set; }
        [Display(Name = "City")]
        public int CityId { get; set; }
        public City City { get; set; }
        [NotMapped]
        [Display(Name = "Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [Display(Name="State")]
        [NotMapped]
        public int StateId { get; set; }
        public State State { get; set; }
    }
}