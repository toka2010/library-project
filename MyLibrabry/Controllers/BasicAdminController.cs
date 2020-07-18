using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrabry.Models;
namespace MyLibrabry.Controllers
{
    public class BasicAdminController : Controller
    {
        // GET: BasicAdmin
        public ActionResult Index()
        {
            int id = int.Parse(Session["u_id"].ToString());
            Users u = UserBL.getById(id);
            return View(u);
        }
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
        public ActionResult CreateAdmin(Users u)
        {
            if (ModelState.IsValid)
            {
                UserBL.InsertAdmin(u);
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
        public ActionResult EditAdmin(Users u)
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

        //BOOOK

        [HttpGet]
        public ActionResult BookB()
        {
            return View(BookBL.GetAll());


        }

        [HttpGet]
        public ViewResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBook(Book u)
        {
            if (ModelState.IsValid)
            {
                BookBL.Insert(u);
                return RedirectToAction("BookB");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult EditBook(int id)
        {
            var u = BookBL.GetById(id);
            return View(u);
        }


        [HttpPost]
        public ActionResult EditBook(Book u)
        {
            if (ModelState.IsValid)
            {
                BookBL.Update(u);
                return RedirectToAction("BookB");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]

        public ActionResult DeleteBook(int id)
        {
            UserBL.Delete(id);
            return RedirectToAction("BookB");
        }


    }

}