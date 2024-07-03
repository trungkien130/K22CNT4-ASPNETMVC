using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LtkK22Cnt4Lesson10Cb.Models;

namespace LtkK22Cnt4Lesson10Cb.Controllers
{
    public class LtkAccountsController : Controller
    {
        private LtkK22Cnt4Lesson10CbEntities db = new LtkK22Cnt4Lesson10CbEntities();

        // GET: LtkAccounts
        public ActionResult Index()
        {
            return View(db.LtkAccounts.ToList());
        }

        // GET: LtkAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkAccount ltkAccount = db.LtkAccounts.Find(id);
            if (ltkAccount == null)
            {
                return HttpNotFound();
            }
            return View(ltkAccount);
        }

        // GET: LtkAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LtkAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LtkID,LtkUserName,LtkPassword,LtkFullName,LtkEmail,LtkPhone,LtkActive")] LtkAccount ltkAccount)
        {
            if (ModelState.IsValid)
            {
                db.LtkAccounts.Add(ltkAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ltkAccount);
        }

        // GET: LtkAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkAccount ltkAccount = db.LtkAccounts.Find(id);
            if (ltkAccount == null)
            {
                return HttpNotFound();
            }
            return View(ltkAccount);
        }

        // POST: LtkAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LtkID,LtkUserName,LtkPassword,LtkFullName,LtkEmail,LtkPhone,LtkActive")] LtkAccount ltkAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltkAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ltkAccount);
        }

        // GET: LtkAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkAccount ltkAccount = db.LtkAccounts.Find(id);
            if (ltkAccount == null)
            {
                return HttpNotFound();
            }
            return View(ltkAccount);
        }

        // POST: LtkAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LtkAccount ltkAccount = db.LtkAccounts.Find(id);
            db.LtkAccounts.Remove(ltkAccount);
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
        //login
        public ActionResult LtkLogin()
        {
            var ltkModel = new LtkAccount();
            return View(ltkModel);
        }
        [HttpPost]
        public ActionResult LtkLogin(LtkAccount ltkAccount)
        {
            var ltkCheck = db.LtkAccounts.Where(x => x.LtkUserName.Equals(ltkAccount.LtkUserName) && x.LtkPassword.Equals(ltkAccount.LtkPassword)).FirstOrDefault();
            if (ltkCheck != null)
            {
                Session["LtkAccount"] = ltkCheck;
                return Redirect("/");
            }
            return View(ltkAccount);
        }
    }
}
