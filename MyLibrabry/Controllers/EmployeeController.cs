using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrabry.Models;
namespace MyLibrabry.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MemberIndex()
        {
            return View(UserBL.GetAllMem());
        }

        [HttpGet]
        public ViewResult CreateMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMember(Users u)
        {
            if (ModelState.IsValid)
            {
                UserBL.InsertMemb(u);
                return RedirectToAction("MemberIndex");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult EditMember(int id)
        {
            var u = UserBL.GetById(id);
            return View(u);
        }


        [HttpPost]
        public ActionResult EditMember(Users u)
        {
            if (ModelState.IsValid)
            {
                UserBL.Update(u);
                return RedirectToAction("MemberIndex");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult DeleteMember(int id)
        {
            UserBL.Delete(id);
            return RedirectToAction("MemberIndex");
        }
    }
}