using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ViewBag.name = "Lê Trung Kiên - 2210900034";
            return View();
        }
        public ActionResult Details(int ? id)
        {
            ViewBag.id = id;
            return View();
        }
        public string GetName()
        {
            return "Lê Trung Kiên - 2210900034";
        }
        public JsonResult ListName()
        {
            string[] names= { "Hùng , Dũng , Sang , Trọng" };
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}