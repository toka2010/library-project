using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrabry.Models;
namespace MyLibrabry.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: User
        public ActionResult AdminIndex()
        {
            return View(UserBL.GetAllAdmin());
        }

        [HttpGet]
        public ViewResult CreateAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAdmin(User u)
        {
            if (ModelState.IsValid)
            {
                UserBL.Insert(u);
                return RedirectToAction("AdminIndex");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult EditAdmin(int id)
        {
            var u = UserBL.GetById(id);
            return View(u);
        }


        [HttpPost]
        public ActionResult EditAdmin(User u)
        {
            if (ModelState.IsValid)
            {
                UserBL.Update(u);
                return RedirectToAction("AdminIndex");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult DeleteAdmin(int id)
        {
            UserBL.Delete(id);
            return RedirectToAction("AdminIndex");
        }


     


    }
}