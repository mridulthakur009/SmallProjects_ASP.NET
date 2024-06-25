using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp_MulTable_Val_MulLayout_PartialView.Models;

namespace WebApp_MulTable_Val_MulLayout_PartialView.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("connectionStrings")
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}