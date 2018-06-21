using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebExercises.Controllers
{
    public class EjerciciosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ej01()
        {
            ViewBag.r = "";
            return View();
        }

        [HttpPost]
        public ActionResult Ej01(int x, int y, int z)
        {
            ViewBag.r = x + y + z;

            return View();
        }

        public ActionResult Ej02()
        {
            ViewBag.msg = "";
            return View();
        }

        [HttpPost]
        public ActionResult Ej02(string name, string city)
        {
            ViewBag.msg = "Hola " + name + "!, Bienvenido a " + city;

            return View();
        }

        public ActionResult Ej03()
        {
            ViewBag.msg = "";
            return View();
        }

        [HttpPost]
        public ActionResult Ej03(string name, int age)
        {
            ViewBag.msg = "Te llamas " + name + " y tienes " + age + " años.";

            return View();
        }

        public ActionResult Ej04()
        {
            ViewBag.msg = "";
            return View();
        }

        [HttpPost]
        public ActionResult Ej04(int x, int y)
        {
            var mayor = x > y ? x : y;

            ViewBag.msg = $"El numero {mayor} es el mayor.";

            return View();
        }

        public ActionResult Ej05()
        {
            ViewBag.msg = "";
            return View();
        }

        [HttpPost]
        public ActionResult Ej05(string day)
        {
            switch (day.ToLower())
            {
                case "sabado":
                case "sábado":
                case "domingo":
                    ViewBag.msg = "Fin de semana!";
                    break;
                case "lunes":
                case "martes":
                case "miércoles":
                case "miercoles":
                case "jueves":
                case "viernes":
                    ViewBag.msg = "Dia de semana :(";
                    break;
                default:
                    ViewBag.msg = "Error! Eso no es un día!";
                    break;
            }


            return View();
        }

        public ActionResult Ej06()
        {
            ViewBag.msg = "";
            return View();
        }

        [HttpPost]
        public ActionResult Ej06(int price, string type, int account=0)
        {
            if (type == "Efectivo")
                ViewBag.msg = $"Precio: {price}, Tipo de pago: {type}";
            else
                ViewBag.msg = $"Precio: {price}, Tipo de pago: {type}, Nro de cuenta: {account}";

            return View();
        }

    }
}