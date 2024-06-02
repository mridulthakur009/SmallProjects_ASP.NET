using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_CodeFirstApproach.Data;

namespace WebApplication_CodeFirstApproach.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeeController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var employeeList = context.Employees.ToList();
            return View(employeeList);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}