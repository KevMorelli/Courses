using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    [RouteArea("test")]
    public class TestController : Controller
    {
        // GET: Test
        
        public ActionResult Hola()
        {
            ViewBag.Message = "Hello World.";
            return View();
        }

        //[HttpPost]
        [Route("hola")]
        public ActionResult Hola2()
        {
            //ViewBag.Message = "Hello World2.";
            return View();
        }
    }
}