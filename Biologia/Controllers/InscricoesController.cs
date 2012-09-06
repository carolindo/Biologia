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
    public class InscricoesController : Controller
    {
        private BiologiaContext context = new BiologiaContext();

        //
        // GET: /Inscricoes/

        public ViewResult Index()
        {
            return View(context.Inscricoes.ToList());
        }

        //
        // GET: /Inscricoes/Details/5

        public ViewResult Details(int id)
        {
            Inscrito inscrito = context.Inscricoes.Single(x => x.inscritoId == id);
            return View(inscrito);
        }

        //
        // GET: /Inscricoes/Create

        public ActionResult Create()
        {
            return View(new Inscrito());
        } 

        //
        // POST: /Inscricoes/Create

        [HttpPost]
        public ActionResult Create(Inscrito inscrito)
        {
            if (ModelState.IsValid)
            {
                context.Inscricoes.Add(inscrito);
                context.SaveChanges();
                return RedirectToAction("TelaConfirmacao", new { inscricaoComSucesso = true });
            }
                return View(inscrito);
        }

        public ActionResult TelaConfirmacao(bool inscricaoComSucesso)
        {
            if (inscricaoComSucesso == true)
                return View();
            else
                return RedirectToAction("Create");
        }
        
        //
        // GET: /Inscricoes/Edit/5
 
        public ActionResult Edit(int id)
        {
            Inscrito inscrito = context.Inscricoes.Single(x => x.inscritoId == id);
            return View(inscrito);
        }

        //
        // POST: /Inscricoes/Edit/5

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
        // GET: /Inscricoes/Delete/5
 
        public ActionResult Delete(int id)
        {
            Inscrito inscrito = context.Inscricoes.Single(x => x.inscritoId == id);
            return View(inscrito);
        }

        //
        // POST: /Inscricoes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Inscrito inscrito = context.Inscricoes.Single(x => x.inscritoId == id);
            context.Inscricoes.Remove(inscrito);
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