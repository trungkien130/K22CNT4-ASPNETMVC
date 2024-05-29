using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab05.Models;

namespace LtkLap05._1.Controllers
{
    public class LtkMemberController : Controller
    {
        // GET: LtkMember/LtkCreateOne
        public ActionResult LtkCreateOne()
        {
            return View();
        }
        //POST: LtkMember/LtkCreateOne
        [HttpPost]
        public ActionResult LtkCreateOne(LtkMember m)
        {
            return View("LtkDetails", m);
        }
        // GET: LtkMember/LtkCreateTwo
        public ActionResult LtkCreateTwo()
        {
            return View();
        }
        //POST: LtkMember/LtkCreateTwo
        [HttpPost]
        public ActionResult LtkCreateTwo(LtkMember m)
        {
            if (m.Id == null)
            {
                ViewBag.error = "Hãy nhập mã số";
                return View();
            }
            if (m.LtkUsername == null)
            {
                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }
            if (m.LtkFullName == null)
            {
                ViewBag.error = "Hãy nhập họ và tên";
                return View();
            }
            if (m.LtkAge == null)
            {
                ViewBag.error = "Hãy nhập tuổi";
                return View();
            }
            if (m.LtkEmail == null)
            {
                ViewBag.error = "Hãy nhập email";
                return View();
            }
            string LtkregePattern = @"[A-Za - z0-9._%+-] + @[A-Za - z0-9.-]+\.[A-Za - z] {2 - 4}";
            if (System.Text.RegularExpressions.Regex.IsMatch(m.LtkEmail, LtkregePattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng";
                return View();
            }
            return View("LtkDetails", m);
        }
        // GET: LtkMember/LtkCreateThree
        public ActionResult LtkCreateThree()
        {
            return View();
        }
        //POST: LtkMember/LtkCreateThree
        [HttpPost]
        public ActionResult LtkCreateThree(LtkMember m)
        {
            if (!ModelState.IsValid)
            {
                return View("LtkDetails", m);
            }
            else
            {
                return View();
            }
        }
        public ActionResult LtkDetails()
        {
            return View();
        }
    }
}