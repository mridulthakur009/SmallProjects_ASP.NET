using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApp_Country_State_City_Reg_EF.Data;
using WebApp_Country_State_City_Reg_EF.Models;

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
        public ActionResult Upsert(int? id)
        {
            ViewBag.CountryList = context.Countries.ToList();
            ViewBag.stateList = context.States.ToList();
            ViewBag.cityList = context.Cities.ToList();

            Register register = new Register();
            if (id == null)
                return View(register);

            //Edit
            register = context.Registers.Find(id);
            if (register == null)
                return HttpNotFound();
            return View(register);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upsert(Register register)
        {
            if (register == null)
                return HttpNotFound();
            if (!ModelState.IsValid)
            {
                ViewBag.countryList = context.Countries.ToList();
                ViewBag.stateList = context.States.ToList();
                ViewBag.cityList = context.Cities.ToList();
                return View();
            }
                if(register.Id == 0)
                    context.Registers.Add(register);
                else
                {
                    var userInDb = context.Registers.Find(register.Id);
                    if (userInDb == null)
                        return HttpNotFound();
                    userInDb.Name = register.Name;
                    userInDb.Email = register.Email;
                    userInDb.Gender = register.Gender;
                    userInDb.Subscribe = register.Subscribe;
                    userInDb.CityId = register.CityId;
                }
                context.SaveChanges();
                return RedirectToAction("Index");
        }

    }
}