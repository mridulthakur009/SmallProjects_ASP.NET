using MVC_withCodeLayout_Validation.Data;
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
    }
}