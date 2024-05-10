using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson3.Controllers
{
    /// <summary>
    /// Author: Lê Trung Kiên
    /// Class: K22CNT4
    /// </summary>
    public class ltkStudent : Controller
    {
        // GET: ltkStudent
        public ActionResult Index()
        {
            ViewBag.fullName = "Lê Trung Kiên";
            ViewData["Birthday"] = "13/02/2004";
            TempData["Phone"] = "0913088169";
            return View();
        }
        public ActionResult Details()
        {
            string ltkStr = "";
            ltkStr += "<h3>Họ và tên: Lê Trung Kiên</h3>";
            ltkStr += "<p>Mã số: 2210900034</p>";
            ltkStr += "<p>Địa chỉ mail: kienlee14@gmail.com</p>";
            ViewBag.Details = ltkStr;
            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            return View();
        }
        // GET: ltkStudent/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            string fullName = form["fullName"];
            string maSV = form["maSV"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];
            string ltkStr = "<h3>" + fullName + "</h3>";
            ltkStr += "<p>" + maSV;
            ltkStr += "<p>" + TaiKhoan;
            ltkStr += "<p>" + MatKhau;

            ViewBag.info = ltkStr;
            return View("KetQua");
        }
    }
}