using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrabry.Models;

namespace MyLibrabry.Controllers
{
    public class userloginController : Controller
    {
        // GET: userlogin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Users lc)

        {
            if (UserBL.checkIn(lc.u_name, lc.u_password) == true)
            {
                if (UserBL.getType(lc.u_name) == "B")
                {
                    Session.Add("u_id", UserBL.GetId(lc.u_name));

                    return RedirectToAction("Index", "BasicAdmin");
                }
                else if (UserBL.getType(lc.u_name) == "A")
                {
                    Session.Add("u_id", UserBL.GetId(lc.u_name));
                    return RedirectToAction("Index", "Admin");
             
                }
                else if (UserBL.getType(lc.u_name) == "E")
                {
                    Session.Add("u_id", UserBL.GetId(lc.u_name));

                    return RedirectToAction("Index","Employee");
                }
                else if (UserBL.getType(lc.u_name) == "M")
                {
                    Session.Add("u_id", UserBL.GetId(lc.u_name));

                    return RedirectToAction("Index", "Member");
                }
              


            }

            return View();
        }
    }
}