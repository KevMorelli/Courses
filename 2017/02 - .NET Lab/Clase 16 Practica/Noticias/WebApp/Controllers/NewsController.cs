using Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class NewsController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Read(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NewDto newDto)
        {
            return View();
        }

        public ActionResult Update(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(NewDto newDto)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}