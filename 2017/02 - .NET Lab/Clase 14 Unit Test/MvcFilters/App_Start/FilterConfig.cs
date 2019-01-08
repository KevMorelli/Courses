using System.Web;
using System.Web.Mvc;
using MvcFilters.Filters;

namespace MvcFilters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new AuthFilterAttribute());
        }
    }
}
