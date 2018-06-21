using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MvcFilters.Filters
{
    public class AuthFilterAttribute : AuthorizeAttribute
    {
        public bool isLogged = false;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (!isLogged)
            {
                throw new HttpException(HttpStatusCode.Unauthorized.ToString());
            }

            return base.AuthorizeCore(httpContext);
        }
    }
}