using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_CodeFirst_WithRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           // routes.IgnoreRoute("Emp/Index"); //This will ignore this route i.e. it will not be accessible by anyone(This will ignore Action specified)
           // routes.IgnoreRoute("Emp/{*pathInfo}"); // This will ignore the whole controller.

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //Custom Route
            routes.MapRoute(
                name: "myRoute",
                url: "routinglearning",
                defaults: new { Controller = "Emp", action = "Index" }
                );

            routes.MapRoute(
                name: "MyMovieName",
                url: "Movie/DateOfRelease/{year}/{month}",
                defaults: new { Controller = "Movie", action = "MovieDate" },
                constraints: new { month = @"\d{2}", year = "\\d{4}" }
                );

            routes.MapMvcAttributeRoutes();
        }
    }
}
