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
    public class InsureeController : Controller
    {
        private Insurance1Entities db = new Insurance1Entities();

        // GET: Insuree1
        public ActionResult Index()
        {
            return View(db.Insurees1.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees1 insuree = db.Insurees1.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees1 insurees1)
        {
            //redirects user to the error page if the values they enter are null or empty
            if (ModelState.IsValid)
            {
                //set up vars 
                DateTime Today = DateTime.Today;
                int Year = Convert.ToInt32(Today.Year);
                int age = DateTime.Now.Year - insurees1.DateOfBirth.Year;

                //start with a base of $50/month
                insurees1.Quote = 50;

                //if the user is 18 and under, add $100 to monthly total
                if (age < 18 || age == 18)
                {
                    insurees1.Quote += 100;
                }

                //if the user is between 19 and 25, add $50 to monthly total
                else if (age > 19 && age < 25 || age == 25 || age == 19)
                {
                    insurees1.Quote += 50;
                }

                //if the user is over 25, add $25 to monthly total
                else if (age > 25)
                {
                    insurees1.Quote += 25;
                }

                //if the car's year is before 2000, add $25 to monthly total
                //if the car's year is after 2015, add $25 to monthly total
                if (insurees1.CarYear < 2000 || insurees1.CarYear > 2015)
                {
                    insurees1.Quote += 25;
                }

                //if the car's Make is a Porsche, add $25 to the price
                //if the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 
                if (insurees1.CarMake == "Porsche" || insurees1.CarMake == "porsche" && insurees1.CarModel == "911 Carrera")
                {
                    if (insurees1.CarMake == "Porsche" || insurees1.CarMake == "porsche")
                    {
                        insurees1.Quote += 25;
                    }
                    insurees1.Quote += 50;
                }

                //add $10 to monthly total for every speeding ticket the user has
                if (insurees1.SpeedingTickets > 0)
                {
                    insurees1.Quote += 10 * insurees1.SpeedingTickets;
                }

                //if the user has ever had a DUI, add 25% to the total
                if (insurees1.DUI)
                {
                    insurees1.Quote *= 1.25m;
                }

                //If it's full coverage, add 50% to the total
                if (insurees1.CoverageType)
                {
                    insurees1.Quote *= 1.5m;
                }

                Console.WriteLine("Your quote is: " + insurees1.Quote);
                db.Insurees1.Add(insurees1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Insuree", insurees1);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees1 insuree = db.Insurees1.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees1 insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees1 insuree = db.Insurees1.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees1 insuree = db.Insurees1.Find(id);
            db.Insurees1.Remove(insuree);
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
