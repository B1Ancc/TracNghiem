﻿using System;
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
    public class MucDoKhoesController : Controller
    {
        private tracnghiemEntities db = new tracnghiemEntities();

        // GET: MucDoKhoes
        public ActionResult Index()
        {
            return View(db.MucDoKhos.ToList());
        }

        // GET: MucDoKhoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MucDoKho mucDoKho = db.MucDoKhos.Find(id);
            if (mucDoKho == null)
            {
                return HttpNotFound();
            }
            return View(mucDoKho);
        }

        // GET: MucDoKhoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MucDoKhoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TenMucDo")] MucDoKho mucDoKho)
        {
            if (ModelState.IsValid)
            {
                db.MucDoKhos.Add(mucDoKho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mucDoKho);
        }

        // GET: MucDoKhoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MucDoKho mucDoKho = db.MucDoKhos.Find(id);
            if (mucDoKho == null)
            {
                return HttpNotFound();
            }
            return View(mucDoKho);
        }

        // POST: MucDoKhoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TenMucDo")] MucDoKho mucDoKho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mucDoKho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mucDoKho);
        }

        // GET: MucDoKhoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MucDoKho mucDoKho = db.MucDoKhos.Find(id);
            if (mucDoKho == null)
            {
                return HttpNotFound();
            }
            return View(mucDoKho);
        }

        // POST: MucDoKhoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MucDoKho mucDoKho = db.MucDoKhos.Find(id);
            db.MucDoKhos.Remove(mucDoKho);
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
