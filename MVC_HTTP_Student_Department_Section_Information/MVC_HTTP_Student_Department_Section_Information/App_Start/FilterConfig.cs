using System.Web;
using System.Web.Mvc;

namespace MVC_HTTP_Student_Department_Section_Information
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
