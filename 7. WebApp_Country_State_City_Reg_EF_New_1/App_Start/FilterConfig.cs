using System.Web;
using System.Web.Mvc;

namespace _7.WebApp_Country_State_City_Reg_EF_New_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
