using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_Country_State_City_Reg_EF.Models
{
    public class State
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public int CouuntryId { get; set; }
        public Country Country { get; set; }
    }
}