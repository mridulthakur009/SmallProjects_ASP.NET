using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MulTable_Val_MulLayout_PartialView.Models
{
    public class Designation
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}