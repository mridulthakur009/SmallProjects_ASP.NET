using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CodeFirst_WithRouting.Controllers
{
    public class MovieController : Controller
    {
        [Route("MyTest")]
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MovieDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}