using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LtkLesson06CF.Models;

namespace LtkLesson06CF.Controllers
{
    public class LtkCategoriesController : Controller
    {
        private static LtkBookStore LtkDb;
        public LtkCategoriesController()
        {
            LtkDb = new LtkBookStore();
        }
        // GET: LtkCategories
        public ActionResult LtkIndex()
        {
            /*
             * Khởi tạo DBcontext;
             * EF sẽ tìm thông tin kết nối trong file machinee.config của .Net Famework trên máy
             * Và sau đó tạo csdl
             * */
            var LtkCategory = LtkDb.LtkCategories.ToList();
            return View(LtkCategory);
        }
        public ActionResult LtkCreate()
        {
            var LtkCategory = new LtkCategory();
            return View(LtkCategory);
        }
        [HttpPost]
        public ActionResult LtkCreate(LtkCategory LtkCategory)
        {
            LtkDb.LtkCategories.Add(LtkCategory);
            LtkDb.SaveChanges();
            return RedirectToAction("LtkIndex");
        }
    }
}