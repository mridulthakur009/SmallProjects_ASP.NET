using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApp_MulTable_Val_MulLayout_PartialView.Data;
using WebApp_MulTable_Val_MulLayout_PartialView.Models;

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
        public ActionResult Upsert(int? id)
        {
            Employee employee = new Employee();
            if (id == null)
                return View(employee);

            //Edit
            employee = context.Employees.Include(e => e.Department)
                                        .Include(e => e.Designation)
                                        .FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return HttpNotFound();
            return View(employee);
        }
    }
}