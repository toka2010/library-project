using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;
using MyLibrabry.Models;

namespace MyLibrabry.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            int id = int.Parse(Session["u_id"].ToString());
            Users u = UserBL.getById(id);
            return View(u);
        }
    }
}