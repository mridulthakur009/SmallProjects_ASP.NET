using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp_Country_State_City_Reg_EF.Models;

namespace WebApp_Country_State_City_Reg_EF.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("connectionStrings")
        {
        }
        //public DbSet<Countryy> Countries { get; set; }
        //public DbSet<Cityy> Cities { get; set; }
        //public DbSet<States> States { get; set; }
        //public DbSet<Registerr> Registers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Register> Registers { get; set; }

    }

}