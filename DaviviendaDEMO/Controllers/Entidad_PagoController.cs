using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DaviviendaDEMO.Models;

namespace DaviviendaDEMO.Controllers
{
    public class Entidad_PagoController : Controller
    {
        private EntidadPagoContext db = new EntidadPagoContext();

        // GET: Entidad_Pago
        public ActionResult Index()
        {
            return View(db.Entidad_Pago.ToList());
        }

        // GET: Entidad_Pago/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidad_Pago entidad_Pago = db.Entidad_Pago.Find(id);
            if (entidad_Pago == null)
            {
                return HttpNotFound();
            }
            return View(entidad_Pago);
        }

        // GET: Entidad_Pago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entidad_Pago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Empresa,Monto,id_usuario,estado")] Entidad_Pago entidad_Pago)
        {
            if (ModelState.IsValid)
            {
                db.Entidad_Pago.Add(entidad_Pago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entidad_Pago);
        }

        // GET: Entidad_Pago/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidad_Pago entidad_Pago = db.Entidad_Pago.Find(id);
            if (entidad_Pago == null)
            {
                return HttpNotFound();
            }
            return View(entidad_Pago);
        }

        // POST: Entidad_Pago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Empresa,Monto,id_usuario,estado")] Entidad_Pago entidad_Pago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entidad_Pago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entidad_Pago);
        }

        // GET: Entidad_Pago/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidad_Pago entidad_Pago = db.Entidad_Pago.Find(id);
            if (entidad_Pago == null)
            {
                return HttpNotFound();
            }
            return View(entidad_Pago);
        }

        // POST: Entidad_Pago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Entidad_Pago entidad_Pago = db.Entidad_Pago.Find(id);
            db.Entidad_Pago.Remove(entidad_Pago);
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
