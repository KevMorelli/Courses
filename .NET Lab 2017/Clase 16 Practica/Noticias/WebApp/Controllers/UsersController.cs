using Services;
using Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class UsersController : Controller
    {
        Service service = new Service();
        
        public ActionResult Index()
        {
            var users = service.ReadUsersService();
            return View(users);
        }
        
        public ActionResult Read(string id)
        {
            var user = service.ReadUserService(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Create(UserDto userDto)
        {
            try
            {
                service.CreateUserService(userDto);
                ViewBag.msg = "User created successfully!";
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
                ViewBag.error = true;
            }

            return View();
        }
        
        public ActionResult Create()
        {
            return View();
        }
        
        public ActionResult Update(string id)
        {
            var user = service.ReadUserService(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Update(UserDto user)
        {
            try
            {
                service.UpdateUserService(user);
                ViewBag.msg = "User modified successfully!";
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
                ViewBag.error = true;
            }
            return View(user);
        }

        public ActionResult Delete(string id)
        {
            try
            {
                service.DeleteUserService(id);
                ViewBag.msg = "User deleted successfully!";
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
                ViewBag.error = true;
            }
            return View();
        }
    }
}