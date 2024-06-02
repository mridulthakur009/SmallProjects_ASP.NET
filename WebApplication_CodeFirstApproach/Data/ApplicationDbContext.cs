
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication_CodeFirstApproach.Models;

namespace WebApplication_CodeFirstApproach.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("connectionString")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> students { get; set; }
    }
}