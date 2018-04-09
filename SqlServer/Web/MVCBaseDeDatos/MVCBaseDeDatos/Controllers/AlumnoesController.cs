using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClassLibrary2;

namespace MVCBaseDeDatos.Controllers
{
    public class AlumnoesController : Controller
    {
        private MVCPruebaEntities db = new MVCPruebaEntities();

        // GET: Alumnoes
        public async Task<ActionResult> Index()
        {
            var alumno = db.Alumno.Include(a => a.Carrera);
            return View(await alumno.ToListAsync());
        }

        // GET: Alumnoes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = await db.Alumno.FindAsync(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // GET: Alumnoes/Create
        public ActionResult Create()
        {
            ViewBag.id_Carrera = new SelectList(db.Carrera, "id_Carrera", "Carrera1");
            return View();
        }

        // POST: Alumnoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id_Alumno,Nombre,Apellido,Edad,id_Carrera")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Alumno.Add(alumno);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.id_Carrera = new SelectList(db.Carrera, "id_Carrera", "Carrera1", alumno.id_Carrera);
            return View(alumno);
        }

        // GET: Alumnoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = await db.Alumno.FindAsync(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_Carrera = new SelectList(db.Carrera, "id_Carrera", "Carrera1", alumno.id_Carrera);
            return View(alumno);
        }

        // POST: Alumnoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id_Alumno,Nombre,Apellido,Edad,id_Carrera")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.id_Carrera = new SelectList(db.Carrera, "id_Carrera", "Carrera1", alumno.id_Carrera);
            return View(alumno);
        }

        // GET: Alumnoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = await db.Alumno.FindAsync(id);
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
            Alumno alumno = await db.Alumno.FindAsync(id);
            db.Alumno.Remove(alumno);
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
