using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TracNghiem.Models;

namespace TracNghiem.Controllers
{
    public class KhoisController : Controller
    {
        private tracnghiemEntities db = new tracnghiemEntities();

        // GET: Khois
        public ActionResult Index()
        {
            return View(db.Khois.ToList());
        }

        // GET: Khois/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khois khois = db.Khois.Find(id);
            if (khois == null)
            {
                return HttpNotFound();
            }
            return View(khois);
        }

        // GET: Khois/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Khois/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TenKhoi,Meta")] Khois khois)
        {
            if (ModelState.IsValid)
            {
                db.Khois.Add(khois);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(khois);
        }

        // GET: Khois/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khois khois = db.Khois.Find(id);
            if (khois == null)
            {
                return HttpNotFound();
            }
            return View(khois);
        }

        // POST: Khois/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TenKhoi,Meta")] Khois khois)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khois).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khois);
        }

        // GET: Khois/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khois khois = db.Khois.Find(id);
            if (khois == null)
            {
                return HttpNotFound();
            }
            return View(khois);
        }

        // POST: Khois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Khois khois = db.Khois.Find(id);
            db.Khois.Remove(khois);
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
