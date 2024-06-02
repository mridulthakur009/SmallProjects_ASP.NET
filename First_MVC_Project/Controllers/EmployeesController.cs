using First_MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_MVC_Project.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            //1st Way
            Employees employee = new Employees();
            employee.ID = 1;
            employee.Name = "Mridul";
            employee.Address = "Dharampur";
            employee.Salary = 95000000;

            //2nd Way
            Employees employee1 = new Employees { ID = 2, Name = "Amit", Address = "Mohali", Salary = 450000 };

            //3rd Way
            Employees employee2 = new Employees()
            {
                ID = 3,
                Name = "Vikas",
                Address = "Chd",
                Salary = 8500000
            };

            return View(employee2);
        }
        public ActionResult GetEmployees()
        {
            List<Employees> employees = new List<Employees>
            {
                new Employees{ID=1,Name="Talasu",Address="Bangalore",Salary=2345679 },
                new Employees{ ID = 2, Name = "Amit", Address = "Mohali", Salary = 450000 },
                new Employees{ID = 3, Name = "Vikas", Address = "Chd",Salary = 8500000}
            };
            return View(employees);
        }
    }
}