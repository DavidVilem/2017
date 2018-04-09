using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCAzure.Models;

namespace MVCAzure.Controllers
{
    public class AlumnoesController : Controller
    {
        private MVCAzureContext db = new MVCAzureContext();

        // GET: Alumnoes
        public async Task<ActionResult> Index()
        {
            return View(await db.Alumnoes.ToListAsync());
        }

        // GET: Alumnoes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = await db.Alumnoes.FindAsync(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // GET: Alumnoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Nombre,Telefono,Direccion")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Alumnoes.Add(alumno);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(alumno);
        }

        // GET: Alumnoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = await db.Alumnoes.FindAsync(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumnoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Nombre,Telefono,Direccion")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(alumno);
        }

        // GET: Alumnoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = await db.Alumnoes.FindAsync(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumnoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Alumno alumno = await db.Alumnoes.FindAsync(id);
            db.Alumnoes.Remove(alumno);
            await db.SaveChangesAsync();
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
