using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Entities;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        /*
         * 1 - crear una clase persona con nombre requerido max 50,
         * apellido requerido max 50,
         * edad (no puede ser menor a 13)
         * 
         * 2- crear un formulario de MVC para crear una persona
         * usar html (no razor)
         */

        public static List<Person> users = new List<Person>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person user)
        {
            users.Add(user);
            return View();
        }

    }
}