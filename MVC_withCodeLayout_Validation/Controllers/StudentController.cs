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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Students student)
        {
            if (student == null)
                return HttpNotFound();
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}