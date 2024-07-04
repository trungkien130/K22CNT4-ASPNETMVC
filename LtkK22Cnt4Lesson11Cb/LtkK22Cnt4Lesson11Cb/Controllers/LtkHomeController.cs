using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LtkK22Cnt4Lesson11Cb.Controllers
{
    public class LtkHomeController : Controller
    {
        public ActionResult LtkIndex()
        {
            return View();
        }

        public ActionResult LtkAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LtkContact()
        {
            ViewBag.mvs = "221090034";
            ViewBag.FullName = "Lê Trung Kiên";
            return View();
        }
    }
}