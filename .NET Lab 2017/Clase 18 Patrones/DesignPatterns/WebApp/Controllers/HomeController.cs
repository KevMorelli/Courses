using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.App_Start;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IClientLogic clientLogic;

        public HomeController(IClientLogic clientLogic)
        {
            this.clientLogic = clientLogic;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}