using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFilters.Filters
{
    public class CookieAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Cookies.Add(new HttpCookie("cookie", "1"));

            base.OnActionExecuting(filterContext);
        }
    }
}