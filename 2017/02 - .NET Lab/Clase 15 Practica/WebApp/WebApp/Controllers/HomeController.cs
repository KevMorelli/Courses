using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Filters;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [NameFilter]
        public ActionResult Index()
        {
            return View();
        }

        [NameFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [NameFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            if (Session["nombre"] == null)
                return View();
            else
                return View("Index");
        }

        [HttpPost]
        public ActionResult LoginResult(string name)
        {
            var count = 1;

            if (HttpContext.Application["count"] == null)
            {
                HttpContext.Application["count"] = 1;
            }
            else
            {
                count = int.Parse(HttpContext.Application["count"].ToString()) + 1;
                HttpContext.Application["count"] = count;

            }
            UsersDB.AddUser(name);
            Session["nombre"] = name;
            if (name == "Admin")
                Session["admin"] = true;

            ViewBag.name = Session["nombre"];
            return View();
        }

        [NameFilter]
        public ActionResult Logout()
        {
            Session.Clear();
            return View("Login");
        }

        [NameFilter]
        public ActionResult Users()
        {
            if (Session["admin"] != null)
                return View();
            else
                return View("Index");
        }


    }
}