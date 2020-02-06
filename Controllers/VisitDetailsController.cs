using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using md753815MIS4200spring.DAL;
using md753815MIS4200spring.Models;

namespace md753815MIS4200spring.Controllers
{
    public class VisitDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: VisitDetails
        public ActionResult Index()
        {
            var visitDetail = db.visitDetail.Include(v => v.Visit);
            return View(visitDetail.ToList());
        }

        // GET: VisitDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitDetail visitDetail = db.visitDetail.Find(id);
            if (visitDetail == null)
            {
                return HttpNotFound();
            }
            return View(visitDetail);
        }

        // GET: VisitDetails/Create
        public ActionResult Create()
        {
            ViewBag.visitId = new SelectList(db.Visit, "visitId", "description");
            return View();
        }

        // POST: VisitDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "visitDetailId,price,description,visitId,petId")] VisitDetail visitDetail)
        {
            if (ModelState.IsValid)
            {
                db.visitDetail.Add(visitDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.visitId = new SelectList(db.Visit, "visitId", "description", visitDetail.visitId);
            return View(visitDetail);
        }

        // GET: VisitDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitDetail visitDetail = db.visitDetail.Find(id);
            if (visitDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.visitId = new SelectList(db.Visit, "visitId", "description", visitDetail.visitId);
            return View(visitDetail);
        }

        // POST: VisitDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "visitDetailId,price,description,visitId,petId")] VisitDetail visitDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visitDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.visitId = new SelectList(db.Visit, "visitId", "description", visitDetail.visitId);
            return View(visitDetail);
        }

        // GET: VisitDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitDetail visitDetail = db.visitDetail.Find(id);
            if (visitDetail == null)
            {
                return HttpNotFound();
            }
            return View(visitDetail);
        }

        // POST: VisitDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VisitDetail visitDetail = db.visitDetail.Find(id);
            db.visitDetail.Remove(visitDetail);
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
