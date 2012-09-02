using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biologia.Models;

namespace Biologia.Controllers
{   
    public class InscritoesController : Controller
    {
        private BiologiaContext context = new BiologiaContext();

        //
        // GET: /Inscritoes/

        public ViewResult Index()
        {
            return View(context.Inscritoes.ToList());
        }

        //
        // GET: /Inscritoes/Details/5

        public ViewResult Details(int id)
        {
            Inscrito inscrito = context.Inscritoes.Single(x => x.inscritoId == id);
            return View(inscrito);
        }

        //
        // GET: /Inscritoes/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Inscritoes/Create

        [HttpPost]
        public ActionResult Create(Inscrito inscrito)
        {
            if (ModelState.IsValid)
            {
                context.Inscritoes.Add(inscrito);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(inscrito);
        }
        
        //
        // GET: /Inscritoes/Edit/5
 
        public ActionResult Edit(int id)
        {
            Inscrito inscrito = context.Inscritoes.Single(x => x.inscritoId == id);
            return View(inscrito);
        }

        //
        // POST: /Inscritoes/Edit/5

        [HttpPost]
        public ActionResult Edit(Inscrito inscrito)
        {
            if (ModelState.IsValid)
            {
                context.Entry(inscrito).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inscrito);
        }

        //
        // GET: /Inscritoes/Delete/5
 
        public ActionResult Delete(int id)
        {
            Inscrito inscrito = context.Inscritoes.Single(x => x.inscritoId == id);
            return View(inscrito);
        }

        //
        // POST: /Inscritoes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Inscrito inscrito = context.Inscritoes.Single(x => x.inscritoId == id);
            context.Inscritoes.Remove(inscrito);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}