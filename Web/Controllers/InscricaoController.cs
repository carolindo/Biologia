using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Data;
using Core.Model;

namespace Web.Controllers
{
    public class InscricaoController : Controller
    {
        private readonly Context _Context = new Context();

        //
        // GET: /Inscricao/
         public ActionResult Index()
        {
            #region Filtro
            //IDictionary<string, string> searchConditions = new Dictionary<string, string>();

            //if (this.Request.Form.AllKeys.Length > 0)
            //{
            //    searchConditions.Add("nome", Request["nome"]);
            //    searchConditions.Add("instituicao", Request["instituicao"]);
            //    searchConditions.Add("email", Request["email"]);
            //    searchConditions.Add("telefone", Request["telefone"]);
            //    searchConditions.Add("curso", Request["curso"]);
            //}
            //else
            //{
            //    object values = null;

            //    if (this.TempData.TryGetValue("SearchConditions", out values))
            //    {
            //        searchConditions = values as Dictionary<string, string>;
            //    }
            //    this.TempData["SearchConditions"] = searchConditions;
            //}
            #endregion

            return View(_Context.Inscricoes);
        }

        //
        // GET: /Inscricao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Inscricao/Create
        public ActionResult Create()
        {
            return View(new Inscricao());
        } 

        //
        // POST: /Inscricao/Create
        [HttpPost]
        public ActionResult Create(Inscricao collection)
        {
            if (collection != null)
            {
                _Context.Inscricoes.Add(collection);
                _Context.SaveChanges();

                return RedirectToAction("TelaConfirmacao", new { inscricaoComSucesso = true });
            }

            return View(collection);
        }

        public ActionResult TelaConfirmacao(bool inscricaoComSucesso)
        {
            if (inscricaoComSucesso == true)
                return View();
            else
                return RedirectToAction("Create");
        }
        
        //
        // GET: /Inscricao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Inscricao/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Inscricao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Inscricao/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
