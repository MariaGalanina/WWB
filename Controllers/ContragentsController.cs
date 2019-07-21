using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ContragentsController : Controller
    {
        private ContragentContext db = new ContragentContext();

        // GET: Contragents
        public ActionResult Index()
        {

            //var contragents = db.Contragents.Include(o => o.Region);

            return View(db.Contragents.ToList());
        }

        // GET: Contragents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contragent contragent = db.Contragents.Find(id);
            if (contragent == null)
            {
                return HttpNotFound();
            }
            return View(contragent);
        }

        // GET: Contragents/Create
        public ActionResult Create()
        {
            //ViewBag.RegionId = new SelectList(db, "RegionId", "Name");
            return View();
        }

        // POST: Contragents/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RegionId,Name,OGRN,INN,KPP,OKPO,DateRegistr,Head,Telephon,Email,Site")] Contragent contragent)
        {
            if (ModelState.IsValid)
            {
                db.Contragents.Add(contragent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contragent);
        }

        // GET: Contragents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contragent contragent = db.Contragents.Find(id);
            if (contragent == null)
            {
                return HttpNotFound();
            }
            return View(contragent);
        }

        // POST: Contragents/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RegionId,Name,OGRN,INN,KPP,OKPO,DateRegistr,Head,Telephon,Email,Site")] Contragent contragent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contragent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contragent);
        }

        // GET: Contragents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contragent contragent = db.Contragents.Find(id);
            if (contragent == null)
            {
                return HttpNotFound();
            }
            return View(contragent);
        }

        // POST: Contragents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contragent contragent = db.Contragents.Find(id);
            db.Contragents.Remove(contragent);
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
