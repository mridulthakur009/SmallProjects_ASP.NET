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
            ViewData["depList"] = context.Departments.ToList();
            ViewData["dsgList"] = context.Designations.ToList();

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upsert(Employee employee)
        {
            if (employee == null)
                return HttpNotFound();
            if (!ModelState.IsValid)
            {
                //ViewData["depList"] = context.Departments.ToList();
                //ViewData["dsgList"] = context.Designations.ToList();
                ViewBag.depList = context.Departments.ToList();
                ViewBag.dsgList = context.Designations.ToList();
                return View(employee);
            }
                
            
            //Adding an employee
            if(employee.Id==0)
                context.Employees.Add(employee);
            else
            {
                //Updating employee
                var employeeInDb = context.Employees.Find(employee.Id);
                if (employeeInDb == null)
                    return HttpNotFound();
                employeeInDb.Name = employee.Name;
                employeeInDb.Address = employee.Address;
                employeeInDb.Salary = employee.Salary;
                employeeInDb.DepartmentId = employee.DepartmentId;
                employeeInDb.DesignationId = employee.DesignationId;
            }
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Details(int? id)
        {
            var employeeInDb = context.Employees.Include(e => e.Department)
                                                .Include(e => e.Designation)
                                                .FirstOrDefault(e => e.Id == id);
            if (employeeInDb == null)
                return HttpNotFound();
            return View(employeeInDb);
        }
    }
}