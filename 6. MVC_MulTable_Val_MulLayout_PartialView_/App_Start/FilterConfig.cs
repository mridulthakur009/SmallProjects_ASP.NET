using System.Web;
using System.Web.Mvc;

namespace _6.MVC_MulTable_Val_MulLayout_PartialView_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
