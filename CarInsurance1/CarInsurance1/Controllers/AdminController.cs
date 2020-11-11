using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance1.Models;

namespace CarInsurance1.Controllers
{
    public class AdminController : Controller
    {
        private Insurance1Entities db = new Insurance1Entities();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Insurees1.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees1 insurees1 = db.Insurees1.Find(id);
            if (insurees1 == null)
            {
                return HttpNotFound();
            }
            return View(insurees1);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees1 insurees1)
        {
            if (ModelState.IsValid)
            {
                db.Insurees1.Add(insurees1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurees1);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees1 insurees1 = db.Insurees1.Find(id);
            if (insurees1 == null)
            {
                return HttpNotFound();
            }
            return View(insurees1);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees1 insurees1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurees1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurees1);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees1 insurees1 = db.Insurees1.Find(id);
            if (insurees1 == null)
            {
                return HttpNotFound();
            }
            return View(insurees1);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees1 insurees1 = db.Insurees1.Find(id);
            db.Insurees1.Remove(insurees1);
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
