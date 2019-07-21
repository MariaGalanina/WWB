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
    public class CompetencesController : Controller
    {
        private CompetenceContext db = new CompetenceContext();

        // GET: Competences
        public ActionResult Index()
        {
            //var comp = db.Competences.Include(p => p.Speciality);
            return View(db.Competences.ToList());
        }

        // GET: Competences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Competence competence = db.Competences.Find(id);
            if (competence == null)
            {
                return HttpNotFound();
            }
            return View(competence);
        }

        // GET: Competences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Competences/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Competence competence)
        {
            if (ModelState.IsValid)
            {
                db.Competences.Add(competence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(competence);
        }

        // GET: Competences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Competence competence = db.Competences.Find(id);
            if (competence == null)
            {
                return HttpNotFound();
            }
            return View(competence);
        }

        // POST: Competences/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Competence competence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(competence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(competence);
        }

        // GET: Competences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Competence competence = db.Competences.Find(id);
            if (competence == null)
            {
                return HttpNotFound();
            }
            return View(competence);
        }

        // POST: Competences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Competence competence = db.Competences.Find(id);
            db.Competences.Remove(competence);
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
