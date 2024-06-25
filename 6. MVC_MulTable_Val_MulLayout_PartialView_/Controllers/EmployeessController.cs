using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApp_MulTable_Val_MulLayout_PartialView.Data;

namespace _6.MVC_MulTable_Val_MulLayout_PartialView_.Controllers
{
    public class EmployeessController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeessController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Employeess
        public ActionResult Index()
        {
            var employeeList = context.Employees.Include(x => x.Department).Include(x => x.Designation).ToList();

            return View(employeeList);
        }
    }
}