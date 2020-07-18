using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrabry.Models;

namespace MyLibrabry.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        [HttpGet]
        public ActionResult Index()
        {
            return View(BookBL.GetAll());
        }
        [HttpGet]
        public ActionResult Index2()
        {
            return View(BookBL.GetAll());
        }



        [HttpGet]
        public ActionResult BookEmp()
        {
            return View(BookBL.GetAll());


        }

        [HttpGet]
        public ViewResult addborrow(int id)
        {
            Session["book_id"] = id;

            return View();
        }


        [HttpPost]
        public ActionResult addborrow(BorrowBook u)
        {
            if (ModelState.IsValid)
            {
                int id = int.Parse(Session["book_id"].ToString());

                BookBL.Insertborrow(u,id);
                return RedirectToAction("BookEmp");
            }
            else
            {
                return View();
            }
        }
        public ActionResult mybook()
        {
            return View(BookBL.allmybook());
        }
        public ActionResult Details(int id)
        {
            return View(BookBL.GetById(id));
        }
    }
}