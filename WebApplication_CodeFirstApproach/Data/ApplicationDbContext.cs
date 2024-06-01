using First_MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication_CodeFirstApproach.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("connectionString")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}