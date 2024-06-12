using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LtkK22CNT4Lesson07DF.Models;

namespace LtkK22CNT4Lesson07DF.Controllers
{
    public class ltkSinhViensController : Controller
    {
        private LtkK22CNT4Lesson7DBEntities1 db = new LtkK22CNT4Lesson7DBEntities1();

        // GET: ltkSinhViens
        public ActionResult LtkIndex()
        {
            var ltkSinhVien = db.ltkSinhVien.Include(l => l.ltkKhoa);
            return View(ltkSinhVien.ToList());
        }

        // GET: ltkSinhViens/Details/5
        public ActionResult LtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ltkSinhVien ltkSinhVien = db.ltkSinhVien.Find(id);
            if (ltkSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(ltkSinhVien);
        }

        // GET: ltkSinhViens/Create
        public ActionResult LtkCreate()
        {
            ViewBag.LtkMaKH = new SelectList(db.ltkKhoa, "ltkMaKH", "ltkTenKhoa");
            return View();
        }

        // POST: ltkSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtkCreate([Bind(Include = "ltkMaSV,LtkHoSV,LtkTenSV,LtkPhai,LtkEmail,LtkPhone,LtkMaKH,LtkTrangThai")] ltkSinhVien ltkSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.ltkSinhVien.Add(ltkSinhVien);
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }

            ViewBag.LtkMaKH = new SelectList(db.ltkKhoa, "ltkMaKH", "ltkTenKhoa", ltkSinhVien.LtkMaKH);
            return View(ltkSinhVien);
        }

        // GET: ltkSinhViens/Edit/5
        public ActionResult LtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ltkSinhVien ltkSinhVien = db.ltkSinhVien.Find(id);
            if (ltkSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.LtkMaKH = new SelectList(db.ltkKhoa, "ltkMaKH", "ltkTenKhoa", ltkSinhVien.LtkMaKH);
            return View(ltkSinhVien);
        }

        // POST: ltkSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtkEdit([Bind(Include = "ltkMaSV,LtkHoSV,LtkTenSV,LtkPhai,LtkEmail,LtkPhone,LtkMaKH,LtkTrangThai")] ltkSinhVien ltkSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltkSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }
            ViewBag.LtkMaKH = new SelectList(db.ltkKhoa, "ltkMaKH", "ltkTenKhoa", ltkSinhVien.LtkMaKH);
            return View(ltkSinhVien);
        }

        // GET: ltkSinhViens/Delete/5
        public ActionResult LtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ltkSinhVien ltkSinhVien = db.ltkSinhVien.Find(id);
            if (ltkSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(ltkSinhVien);
        }

        // POST: ltkSinhViens/Delete/5
        [HttpPost, ActionName("LtkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ltkSinhVien ltkSinhVien = db.ltkSinhVien.Find(id);
            db.ltkSinhVien.Remove(ltkSinhVien);
            db.SaveChanges();
            return RedirectToAction("LtkIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
