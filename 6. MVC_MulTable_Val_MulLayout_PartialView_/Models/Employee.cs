using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp_MulTable_Val_MulLayout_PartialView.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required(ErrorMessage = "Address Empty!!!")]
        public String Address { get; set; }
        [Required]
        [Range(20000, 50000, ErrorMessage = "Salary should be between 20K to 50K")]
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }

    }
}