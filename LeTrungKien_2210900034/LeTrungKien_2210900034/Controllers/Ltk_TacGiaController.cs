using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LeTrungKien_2210900034.Models;

namespace LeTrungKien_2210900034.Controllers
{
    public class Ltk_TacGiaController : Controller
    {
        private LeTrungKien_2210900034Entities db = new LeTrungKien_2210900034Entities();

        // GET: Ltk_TacGia
        public ActionResult LtkIndex()
        {
            return View(db.Ltk_TacGia.ToList());
        }

        // GET: Ltk_TacGia/Details/5
        public ActionResult LtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ltk_TacGia ltk_TacGia = db.Ltk_TacGia.Find(id);
            if (ltk_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(ltk_TacGia);
        }

        // GET: Ltk_TacGia/Create
        public ActionResult LtkCreate()
        {
            return View();
        }

        // POST: Ltk_TacGia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtkCreate([Bind(Include = "Ltk_MaTG,Ltk_TenTG")] Ltk_TacGia ltk_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Ltk_TacGia.Add(ltk_TacGia);
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }

            return View(ltk_TacGia);
        }

        // GET: Ltk_TacGia/Edit/5
        public ActionResult LtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ltk_TacGia ltk_TacGia = db.Ltk_TacGia.Find(id);
            if (ltk_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(ltk_TacGia);
        }

        // POST: Ltk_TacGia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtkEdit([Bind(Include = "Ltk_MaTG,Ltk_TenTG")] Ltk_TacGia ltk_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltk_TacGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }
            return View(ltk_TacGia);
        }

        // GET: Ltk_TacGia/Delete/5
        public ActionResult LtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ltk_TacGia ltk_TacGia = db.Ltk_TacGia.Find(id);
            if (ltk_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(ltk_TacGia);
        }

        // POST: Ltk_TacGia/Delete/5
        [HttpPost, ActionName("LtkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ltk_TacGia ltk_TacGia = db.Ltk_TacGia.Find(id);
            db.Ltk_TacGia.Remove(ltk_TacGia);
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
