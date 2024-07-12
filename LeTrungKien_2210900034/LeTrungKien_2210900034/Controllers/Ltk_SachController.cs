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
    public class Ltk_SachController : Controller
    {
        private LeTrungKien_2210900034Entities db = new LeTrungKien_2210900034Entities();

        // GET: Ltk_Sach
        public ActionResult LtkIndex()
        {
            var ltk_Sach = db.Ltk_Sach.Include(l => l.Ltk_TacGia);
            return View(ltk_Sach.ToList());
        }

        // GET: Ltk_Sach/Details/5
        public ActionResult LtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ltk_Sach ltk_Sach = db.Ltk_Sach.Find(id);
            if (ltk_Sach == null)
            {
                return HttpNotFound();
            }
            return View(ltk_Sach);
        }

        // GET: Ltk_Sach/Create
        public ActionResult LtkCreate()
        {
            ViewBag.Ltk_MaTG = new SelectList(db.Ltk_TacGia, "Ltk_MaTG", "Ltk_TenTG");
            return View();
        }

        // POST: Ltk_Sach/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtkCreate([Bind(Include = "Ltk_MaSach,Ltk_TenSach,Ltk_SoTrang,Ltk_NamXB,Ltk_MaTG,Ltk_TrangThai")] Ltk_Sach ltk_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Ltk_Sach.Add(ltk_Sach);
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }

            ViewBag.Ltk_MaTG = new SelectList(db.Ltk_TacGia, "Ltk_MaTG", "Ltk_TenTG", ltk_Sach.Ltk_MaTG);
            return View(ltk_Sach);
        }

        // GET: Ltk_Sach/Edit/5
        public ActionResult LtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ltk_Sach ltk_Sach = db.Ltk_Sach.Find(id);
            if (ltk_Sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ltk_MaTG = new SelectList(db.Ltk_TacGia, "Ltk_MaTG", "Ltk_TenTG", ltk_Sach.Ltk_MaTG);
            return View(ltk_Sach);
        }

        // POST: Ltk_Sach/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtkEdit([Bind(Include = "Ltk_MaSach,Ltk_TenSach,Ltk_SoTrang,Ltk_NamXB,Ltk_MaTG,Ltk_TrangThai")] Ltk_Sach ltk_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltk_Sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }
            ViewBag.Ltk_MaTG = new SelectList(db.Ltk_TacGia, "Ltk_MaTG", "Ltk_TenTG", ltk_Sach.Ltk_MaTG);
            return View(ltk_Sach);
        }

        // GET: Ltk_Sach/Delete/5
        public ActionResult LtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ltk_Sach ltk_Sach = db.Ltk_Sach.Find(id);
            if (ltk_Sach == null)
            {
                return HttpNotFound();
            }
            return View(ltk_Sach);
        }

        // POST: Ltk_Sach/Delete/5
        [HttpPost, ActionName("LtkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ltk_Sach ltk_Sach = db.Ltk_Sach.Find(id);
            db.Ltk_Sach.Remove(ltk_Sach);
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
