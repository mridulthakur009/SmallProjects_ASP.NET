using First_MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_MVC_Project.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            //1st Way
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "Mridul";
            employee.Address = "Dharampur";
            employee.Salary = 95000000;

            //2nd Way
            Employee employee1 = new Employee { ID = 2, Name = "Amit", Address = "Mohali", Salary = 450000 };

            //3rd Way
            Employee employee2 = new Employee()
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
            List<Employee> employees = new List<Employee>
            {
                new Employee{ID=1,Name="Talasu",Address="Bangalore",Salary=2345679 },
                new Employee{ ID = 2, Name = "Amit", Address = "Mohali", Salary = 450000 },
                new Employee{ID = 3, Name = "Vikas", Address = "Chd",Salary = 8500000}
            };
            return View(employees);
        }
    }
}