using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrabry.Models;
namespace MyLibrabry.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            int id = int.Parse(Session["u_id"].ToString());
            Users u = UserBL.getById(id);
            return View(u);
        }

        [HttpGet]
        public ViewResult EditIndex(int id)
        {
        

            Session["u_id"] = id;
            var a = UserBL.GetById(id);
            return View(a);
        }


        [HttpPost]
        public ActionResult EditIndex(Users u)
        {
            if (ModelState.IsValid)
            {
                UserBL.Update(u);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult EmployeeIndex()
        {
            return View(UserBL.GetAllEmp());
        }

        [HttpGet]
        public ViewResult CreateEmployee()
        {
            return View();
        
        }

        [HttpPost]
        public ActionResult CreateEmployee(Users u)
        {
            if (ModelState.IsValid)
            {
                UserBL.InsertEmp(u);
                return RedirectToAction("EmployeeIndex");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult EditEmployee(int id)
        {
            var u = UserBL.GetById(id);
            return View(u);
        }


        [HttpPost]
        public ActionResult EditEmployee(Users u)
        {
            if (ModelState.IsValid)
            {
                UserBL.Update(u);
                return RedirectToAction("EmployeeIndex");
        }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult DeleteEmployee(int id)
        {
            UserBL.Delete(id);
            return RedirectToAction("EmployeeIndex");
        }
    }
}