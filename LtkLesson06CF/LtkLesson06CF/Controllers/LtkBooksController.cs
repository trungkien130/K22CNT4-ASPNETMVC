using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LtkLesson06CF.Models;

namespace LtkLesson06CF.Controllers
{
    public class LtkBooksController : Controller
    {
        private LtkBookStore db = new LtkBookStore();

        // GET: LtkBooks
        public ActionResult Index()
        {
            return View(db.LtkBooks.ToList());
        }

        // GET: LtkBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkBook LtkBook = db.LtkBooks.Find(id);
            if (LtkBook == null)
            {
                return HttpNotFound();
            }
            return View(LtkBook);
        }

        // GET: LtkBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LtkBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LtkId,LtkBookId,LtkTitle,LtkAuthor,LtkYear,LtkPublic,LtkPicture,LtkCategoryId")] LtkBook LtkBook)
        {
            if (ModelState.IsValid)
            {
                db.LtkBooks.Add(LtkBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(LtkBook);
        }

        // GET: LtkBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkBook LtkBook = db.LtkBooks.Find(id);
            if (LtkBook == null)
            {
                return HttpNotFound();
            }
            return View(LtkBook);
        }

        // POST: LtkBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LtkId,LtkBookId,LtkTitle,LtkAuthor,LtkYear,LtkPublic,LtkPicture,LtkCategoryId")] LtkBook LtkBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(LtkBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(LtkBook);
        }

        // GET: LtkBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkBook LtkBook = db.LtkBooks.Find(id);
            if (LtkBook == null)
            {
                return HttpNotFound();
            }
            return View(LtkBook);
        }

        // POST: LtkBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LtkBook LtkBook = db.LtkBooks.Find(id);
            db.LtkBooks.Remove(LtkBook);
            db.SaveChanges();
            return RedirectToAction("Index");
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
