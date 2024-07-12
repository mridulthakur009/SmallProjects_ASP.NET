using System.Web;
using System.Web.Mvc;

namespace _7.WebApp_Country_State_City
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
