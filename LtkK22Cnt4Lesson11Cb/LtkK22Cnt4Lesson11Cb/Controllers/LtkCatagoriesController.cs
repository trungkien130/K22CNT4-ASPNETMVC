using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LtkK22Cnt4Lesson11Cb.Models;

namespace LtkK22Cnt4Lesson11Cb.Controllers
{
    public class LtkCatagoriesController : Controller
    {
        private LtkK22Cnt4Lesson11CbEntities1 db = new LtkK22Cnt4Lesson11CbEntities1();

        // GET: LtkCatagories
        public ActionResult LtkIndex()
        {
            return View(db.LtkCatagory.ToList());
        }

        // GET: LtkCatagories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkCatagory ltkCatagory = db.LtkCatagory.Find(id);
            if (ltkCatagory == null)
            {
                return HttpNotFound();
            }
            return View(ltkCatagory);
        }

        // GET: LtkCatagories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LtkCatagories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LtkID,LtkCateName,LtkStatus")] LtkCatagory ltkCatagory)
        {
            if (ModelState.IsValid)
            {
                db.LtkCatagory.Add(ltkCatagory);
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }

            return View(ltkCatagory);
        }

        // GET: LtkCatagories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkCatagory ltkCatagory = db.LtkCatagory.Find(id);
            if (ltkCatagory == null)
            {
                return HttpNotFound();
            }
            return View(ltkCatagory);
        }

        // POST: LtkCatagories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LtkID,LtkCateName,LtkStatus")] LtkCatagory ltkCatagory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltkCatagory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }
            return View(ltkCatagory);
        }

        // GET: LtkCatagories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkCatagory ltkCatagory = db.LtkCatagory.Find(id);
            if (ltkCatagory == null)
            {
                return HttpNotFound();
            }
            return View(ltkCatagory);
        }

        // POST: LtkCatagories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LtkCatagory ltkCatagory = db.LtkCatagory.Find(id);
            db.LtkCatagory.Remove(ltkCatagory);
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
