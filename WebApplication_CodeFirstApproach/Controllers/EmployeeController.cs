﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_CodeFirstApproach.Data;
using WebApplication_CodeFirstApproach.Models;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (employee == null)
                return HttpNotFound();
            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var employeeInDB = context.Employees.Find(id);

            var employeeInDb = context.Employees.FirstOrDefault(e => e.ID == id);

            var employeesInDb = context.Employees.Where(e => e.ID == id);

            if (employeeInDB == null)
                return HttpNotFound();
            return View(employeeInDB);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (employee == null)
                return HttpNotFound();
            var employeeInDb = context.Employees.Find(employee.ID);
            if (employeeInDb == null)
                return HttpNotFound();
            employeeInDb.Name = employee.Name;
            employeeInDb.Address = employee.Address;
            employeeInDb.Salary = employee.Salary;

            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Details(int id)
        {
            var employeeInDb = context.Employees.Find(id);
            if (employeeInDb == null)
                return HttpNotFound();
            return View(employeeInDb);
        }
        public ActionResult Delete(int id)
        {
            var employeeInDb = context.Employees.Find(id);
            if (employeeInDb == null)
                return HttpNotFound();
            return View(employeeInDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Employee employee)
        {
            var employeeInDb = context.Employees.Find(employee.ID);
            if (employeeInDb == null)
                return HttpNotFound();
            context.Employees.Remove(employeeInDb);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}