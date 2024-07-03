using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LtkK22Cnt4Lesson10Cb.Models;

namespace LtkK22Cnt4Lesson10Cb.Controllers
{
    public class LtkHomeController : Controller
    {
        public ActionResult LtkIndex()
        {
            if (Session["LtkAccount"] != null)
            {
                var ltkAccount = Session["LtkAccount"] as LtkAccount;
                ViewBag.FullName = ltkAccount.LtkFullName;
            }
            return View();
        }

        public ActionResult LtkAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LtkContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}