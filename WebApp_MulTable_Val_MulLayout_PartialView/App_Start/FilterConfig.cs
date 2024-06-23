using System.Web;
using System.Web.Mvc;

namespace WebApp_MulTable_Val_MulLayout_PartialView
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
