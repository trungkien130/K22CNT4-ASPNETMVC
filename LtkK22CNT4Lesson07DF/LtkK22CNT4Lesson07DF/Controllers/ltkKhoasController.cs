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
    public class ltkKhoasController : Controller
    {
        private LtkK22CNT4Lesson7DBEntities1 db = new LtkK22CNT4Lesson7DBEntities1();

        // GET: ltkKhoas
        public ActionResult LtkIndex()
        {
            return View(db.ltkKhoa.ToList());
        }

        // GET: ltkKhoas/Details/5
        public ActionResult LtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ltkKhoa ltkKhoa = db.ltkKhoa.Find(id);
            if (ltkKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ltkKhoa);
        }

        // GET: ltkKhoas/Create
        public ActionResult LtkCreate()
        {
            return View();
        }

        // POST: ltkKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtkCreate([Bind(Include = "ltkMaKH,ltkTenKhoa,ltkTrangThai")] ltkKhoa ltkKhoa)
        {
            if (ModelState.IsValid)
            {
                db.ltkKhoa.Add(ltkKhoa);
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }

            return View(ltkKhoa);
        }

        // GET: ltkKhoas/Edit/5
        public ActionResult LtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ltkKhoa ltkKhoa = db.ltkKhoa.Find(id);
            if (ltkKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ltkKhoa);
        }

        // POST: ltkKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtkEdit([Bind(Include = "ltkMaKH,ltkTenKhoa,ltkTrangThai")] ltkKhoa ltkKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltkKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }
            return View(ltkKhoa);
        }

        // GET: ltkKhoas/Delete/5
        public ActionResult LtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ltkKhoa ltkKhoa = db.ltkKhoa.Find(id);
            if (ltkKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ltkKhoa);
        }

        // POST: ltkKhoas/Delete/5
        [HttpPost, ActionName("LtkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ltkKhoa ltkKhoa = db.ltkKhoa.Find(id);
            db.ltkKhoa.Remove(ltkKhoa);
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
