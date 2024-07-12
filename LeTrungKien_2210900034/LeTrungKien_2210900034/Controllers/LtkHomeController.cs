using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeTrungKien_2210900034.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}