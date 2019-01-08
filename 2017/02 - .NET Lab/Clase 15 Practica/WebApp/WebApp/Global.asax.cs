using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        
        protected void Session_Start(Object sender, EventArgs e)
        {
            //var count = 1;

            //if (HttpContext.Current.Application["count"] == null)
            //{
            //    HttpContext.Current.Application["count"] = 1;
            //}
            //else
            //{
            //    count = int.Parse(HttpContext.Current.Application["count"].ToString()) + 1;
            //    HttpContext.Current.Application["count"] = count;

            //}
        }
        

    }
}
