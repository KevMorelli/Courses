using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Filters
{
    public class CountFilter : ActionFilterAttribute
    {
        public override object TypeId => base.TypeId;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool IsDefaultAttribute()
        {
            return base.IsDefaultAttribute();
        }

        public override bool Match(object obj)
        {
            return base.Match(obj);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //var count = 1;

            if (HttpContext.Current.Application["count"] == null)
            {
                HttpContext.Current.Application["count"] = 1;
            }
            //else
            //{
            //        count = int.Parse(HttpContext.Current.Application["count"].ToString()) + 1;
            //        HttpContext.Current.Application["count"] = count;

            //}
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}