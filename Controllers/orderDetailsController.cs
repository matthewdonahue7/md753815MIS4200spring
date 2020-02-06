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
    public class orderDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: orderDetails
        public ActionResult Index()
        {
            var orderDetail = db.OrderDetail.Include(o => o.Product);
            return View(orderDetail.ToList());
        }

        // GET: orderDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            orderDetail orderDetail = db.OrderDetail.Find(id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            return View(orderDetail);
        }

        // GET: orderDetails/Create
        public ActionResult Create()
        {
            ViewBag.productID = new SelectList(db.Product, "productID", "description");
            return View();
        }

        // POST: orderDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "orderdetailID,qtyOrdered,price,orderID,productID")] orderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                db.OrderDetail.Add(orderDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.productID = new SelectList(db.Product, "productID", "description", orderDetail.productID);
            return View(orderDetail);
        }

        // GET: orderDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            orderDetail orderDetail = db.OrderDetail.Find(id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.productID = new SelectList(db.Product, "productID", "description", orderDetail.productID);
            return View(orderDetail);
        }

        // POST: orderDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "orderdetailID,qtyOrdered,price,orderID,productID")] orderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.productID = new SelectList(db.Product, "productID", "description", orderDetail.productID);
            return View(orderDetail);
        }

        // GET: orderDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            orderDetail orderDetail = db.OrderDetail.Find(id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            return View(orderDetail);
        }

        // POST: orderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            orderDetail orderDetail = db.OrderDetail.Find(id);
            db.OrderDetail.Remove(orderDetail);
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
