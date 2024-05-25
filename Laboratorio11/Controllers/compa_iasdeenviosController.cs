using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Laboratorio11.Models;

namespace Laboratorio11.Controllers
{
    public class compa_iasdeenviosController : Controller
    {
        private NeptunoEntities db = new NeptunoEntities();

        // GET: compa_iasdeenvios
        public ActionResult Index()
        {
            return View(db.compa_iasdeenvios.ToList());
        }

        // GET: compa_iasdeenvios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            compa_iasdeenvios compa_iasdeenvios = db.compa_iasdeenvios.Find(id);
            if (compa_iasdeenvios == null)
            {
                return HttpNotFound();
            }
            return View(compa_iasdeenvios);
        }

        // GET: compa_iasdeenvios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: compa_iasdeenvios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCompa_iaEnvios,nombreCompa_ia,telefono")] compa_iasdeenvios compa_iasdeenvios)
        {
            if (ModelState.IsValid)
            {
                db.compa_iasdeenvios.Add(compa_iasdeenvios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(compa_iasdeenvios);
        }

        // GET: compa_iasdeenvios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            compa_iasdeenvios compa_iasdeenvios = db.compa_iasdeenvios.Find(id);
            if (compa_iasdeenvios == null)
            {
                return HttpNotFound();
            }
            return View(compa_iasdeenvios);
        }

        // POST: compa_iasdeenvios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCompa_iaEnvios,nombreCompa_ia,telefono")] compa_iasdeenvios compa_iasdeenvios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compa_iasdeenvios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compa_iasdeenvios);
        }

        // GET: compa_iasdeenvios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            compa_iasdeenvios compa_iasdeenvios = db.compa_iasdeenvios.Find(id);
            if (compa_iasdeenvios == null)
            {
                return HttpNotFound();
            }
            return View(compa_iasdeenvios);
        }

        // POST: compa_iasdeenvios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            compa_iasdeenvios compa_iasdeenvios = db.compa_iasdeenvios.Find(id);
            db.compa_iasdeenvios.Remove(compa_iasdeenvios);
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
