using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create(string firstName)
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageTypre, Quote")] Table table)
        {
            if (ModelState.IsValid)


            {
                // Quote is assigned the base rate
                table.Qoute = 50;

                // Save today's date.
                var today = DateTime.Today;

                // Calculate insuree age.
                var age = today.Year - table.DateOfBirth.Year;

                // This goes through several checks and adds to the base quote accordingly
                // This probably could be made more efficient, but this is easier to write out and understand
                if (age <= 18)
                {
                    table.Qoute = table.Qoute + 100;
                }

                if (age >= 19 && age <= 25)
                {
                    table.Qoute = table.Qoute + 50;
                }

                if (age > 25)
                {
                    table.Qoute = table.Qoute + 25;
                }

                if (table.CarYear < 2000)
                {
                    table.Qoute = table.Qoute + 25;
                }

                if (table.CarYear > 2015)
                {
                    table.Qoute = table.Qoute + 25;
                }

                if (table.CarMake == "Porsche")
                {
                    table.Qoute = table.Qoute + 25;
                }

                if (table.CarMake == "Porsche" && table.CarModel == "911 Carrera")
                {
                    table.Qoute = table.Qoute + 25;
                }

                if (table.SpeedingTickets > 0)
                {
                    int tickets = table.SpeedingTickets;
                    int ticketTotal = (10 * tickets);
                    table.Qoute = table.Qoute + ticketTotal;
                }

                if (table.DUI == true)
                {
                    decimal totalMultiplier = (decimal).25;

                    decimal total = table.Qoute * totalMultiplier;
                    table.Qoute = table.Qoute + total;
                }

                if (table.CoverageTypre == true)
                {
                    decimal totalMultiplier = (decimal).50;

                    decimal total = table.Qoute * totalMultiplier;
                    table.Qoute = table.Qoute + total;
                }

                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }




        //        db.Tables.Add(table);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(table);
        //}

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageTypre,Qoute")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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
