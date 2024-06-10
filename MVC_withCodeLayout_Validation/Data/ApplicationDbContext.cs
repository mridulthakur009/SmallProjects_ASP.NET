using MVC_withCodeLayout_Validation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_withCodeLayout_Validation.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("conStr")
        {
        }
        public DbSet<Students> Students { get; set; }
    }
}