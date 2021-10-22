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
        public InsuranceEntities db = new InsuranceEntities();

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
        public ActionResult Create
            (string firstname,
            string lastname,
            string emailaddress,
            DateTime dateofbirth,
            int caryear,
            string carmake,
            string carmodel,
            bool dui,
            int speedtickets,
            bool coveragetypre,
            int? qoute)
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(emailaddress) || string.IsNullOrEmpty(carmake) || string.IsNullOrEmpty(carmodel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var s = new Table();
                    s.FirstName = firstname;
                    s.LastName = lastname;
                    s.EmailAddress = emailaddress;
                    s.DateOfBirth = dateofbirth;
                    s.CarYear = caryear;
                    s.CarMake = carmake;
                    s.CarModel = carmodel;
                    s.DUI = dui;
                    s.SpeedingTickets = speedtickets;
                    s.CoverageTypre = coveragetypre;
                    s.Qoute = (decimal)qoute;
                    qoute = 50;
                    var today = DateTime.Today;
                    var age = today.Year - dateofbirth.Year;
                    if (dateofbirth > today.AddYears(-25))
                    {
                        qoute = qoute + 25;
                    }
                    else if (dateofbirth > today.AddYears(-18))
                    {
                        qoute = qoute + 100;
                    }
                    else if (dateofbirth > today.AddYears(-100))
                    {
                        qoute = qoute + 25;
                    }
                    if (caryear < 2000)
                    {
                        qoute = qoute + 25;
                    }
                    else if (caryear > 2015)
                    {
                        qoute = qoute + 25;
                    }
                    if (carmake == "Porsche")
                    {
                        qoute = qoute + 25;
                    }
                    if (carmake == "Porsche" && carmodel == "911 Carrera")
                    {
                        qoute = qoute + 25;
                    }
                    if (speedtickets > 0)
                    {
                        qoute = qoute + (speedtickets * 10);
                    }
                    if (dui == true)
                    {
                        qoute = qoute + (qoute * 25 / 100);
                    }
                    else
                    {
                        qoute = qoute + 0;
                    }
                    if (coveragetypre == true)
                    {
                        qoute = qoute + (qoute * 50 / 100);
                    }
                    else
                    {
                        qoute = qoute + 0;
                    }
                    s.Qoute = (decimal)qoute;
                    {
                        return View();
                    }

                    // POST: Insuree/Create
                    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
                    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
                    [HttpPost]
                    [ValidateAntiForgeryToken]
                    public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageTypre, Quote")] Table table, InsuranceEntities db)
                    {
                        if (ModelState.IsValid)
                        {
                            db.Tables.Add(table);
                            db.SaveChanges();
                            return RedirectToAction("Index");
                        }

                        return View(table);
                    }

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
                }
            }
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
