using MVC_withCodeLayout_Validation.Data;
using MVC_withCodeLayout_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_withCodeLayout_Validation.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext context;
        public StudentController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Student
        public ActionResult Index()
        {
            return View(context.Students.ToList());
        }
        public ViewResult Create()
        {
            return View();
        }

        //public ActionResult Create(Students student)
        //{
        //    if (student == null)
        //        return HttpNotFound();
        //    context.Students.Add(student);
        //    context.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Students students)
        {
            if (students == null)
                return HttpNotFound();
            if (!ModelState.IsValid) //Server Side Validation
                return View();

            //Unique Email Check Start

            var emailCheck = context.Students.FirstOrDefault(s => s.Email == students.Email);
            if(emailCheck != null)
            {
                ModelState.AddModelError("Email", "Email is already in use !!!");
                return View();
            }

            //Unique Email Check End

            context.Students.Add(students);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //public ActionResult Edit(int id)
        //{
        //    var studentInDb = context.Students.Find(id);
        //    if (studentInDb == null)
        //        return HttpNotFound();
        //    return View(studentInDb);
        //}
        public ActionResult Edit(int? id)
        {
            var studentInDb = context.Students.Find(id);
            if (studentInDb == null)
                return HttpNotFound();
            return View(studentInDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Students students)
        {
            if (students == null)
                return HttpNotFound();
            var studentFromDb = context.Students.Find(students.Id);
            if (studentFromDb == null)
                return HttpNotFound();

            //Email Validation (Server Side Validation)
            var duplicateEmail = context.Students.FirstOrDefault
                (s => s.Email == students.Email);
            var emailId = context.Students.FirstOrDefault
                (s => s.Id == students.Id);

            if(duplicateEmail != null)
            {
                ModelState.AddModelError("Email", "Email in use ! ! !");
                return View();
            }

            studentFromDb.Name = students.Name;
            studentFromDb.Age = students.Age;
            studentFromDb.Email = students.Email;
            studentFromDb.Address = students.Address;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            var studentInDb = context.Students.Find(id);
            if (studentInDb == null)
                return HttpNotFound();
            return View(studentInDb);
        }

    }
}