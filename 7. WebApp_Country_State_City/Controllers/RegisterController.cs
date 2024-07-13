using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApp_Country_State_City_Reg_EF.Data;

namespace _7.WebApp_Country_State_City.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext context;
        public RegisterController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Register
        public ActionResult Index()
        {
            var userList = context.Registers.Include(r => r.City)
                                            .Include(r => r.City.State)
                                            .Include(r => r.City.State.Country).ToList();
            return View(userList);
        }
    }
}