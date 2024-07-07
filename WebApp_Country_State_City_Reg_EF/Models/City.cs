using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_Country_State_City_Reg_EF.Models
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public int  StateId { get; set; }
        public State State { get; set; }
    }
}