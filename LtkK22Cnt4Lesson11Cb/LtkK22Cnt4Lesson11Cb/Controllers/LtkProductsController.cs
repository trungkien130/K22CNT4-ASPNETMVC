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
    public class LtkProductsController : Controller
    {
        private LtkK22Cnt4Lesson11CbEntities1 db = new LtkK22Cnt4Lesson11CbEntities1();

        // GET: LtkProducts
        public ActionResult LtkIndex()
        {
            var ltkProduct = db.LtkProduct.Include(l => l.LtkCatagory);
            return View(ltkProduct.ToList());
        }

        // GET: LtkProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkProduct ltkProduct = db.LtkProduct.Find(id);
            if (ltkProduct == null)
            {
                return HttpNotFound();
            }
            return View(ltkProduct);
        }

        // GET: LtkProducts/Create
        public ActionResult Create()
        {
            ViewBag.LtkCateId = new SelectList(db.LtkCatagory, "LtkID", "LtkCateName");
            return View();
        }

        // POST: LtkProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LtkID2210900034,LtkProName,LtkQty,LtkPrice,LtkCateId,LtkActive")] LtkProduct ltkProduct)
        {
            if (ModelState.IsValid)
            {
                db.LtkProduct.Add(ltkProduct);
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }

            ViewBag.LtkCateId = new SelectList(db.LtkCatagory, "LtkID", "LtkCateName", ltkProduct.LtkCateId);
            return View(ltkProduct);
        }

        // GET: LtkProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkProduct ltkProduct = db.LtkProduct.Find(id);
            if (ltkProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.LtkCateId = new SelectList(db.LtkCatagory, "LtkID", "LtkCateName", ltkProduct.LtkCateId);
            return View(ltkProduct);
        }

        // POST: LtkProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LtkID2210900034,LtkProName,LtkQty,LtkPrice,LtkCateId,LtkActive")] LtkProduct ltkProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltkProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LtkIndex");
            }
            ViewBag.LtkCateId = new SelectList(db.LtkCatagory, "LtkID", "LtkCateName", ltkProduct.LtkCateId);
            return View(ltkProduct);
        }

        // GET: LtkProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkProduct ltkProduct = db.LtkProduct.Find(id);
            if (ltkProduct == null)
            {
                return HttpNotFound();
            }
            return View(ltkProduct);
        }

        // POST: LtkProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LtkProduct ltkProduct = db.LtkProduct.Find(id);
            db.LtkProduct.Remove(ltkProduct);
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
