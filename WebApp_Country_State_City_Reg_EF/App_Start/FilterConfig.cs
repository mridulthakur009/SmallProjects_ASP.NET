using System.Web;
using System.Web.Mvc;

namespace WebApp_Country_State_City_Reg_EF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
