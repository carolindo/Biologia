using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Web.Controllers
{
    public class AdministracaoController : Controller
    {
        //
        // GET: /Administracao/
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LogOn", "Account");
            }
        }

        //
        // GET: /Administracao/Perfil
        public ActionResult Perfil()
        {
            if (Request.IsAuthenticated)
            {
                var user = Membership.GetAllUsers().Cast<MembershipUser>().Where(u => u.IsApproved).First();

                return View(user);
            }
            else
            {
                return RedirectToAction("LogOn", "Account");
            }
        }

        //
        // GET: /Administracao/Listar
        public ActionResult Listar()
        {
            if (Request.IsAuthenticated)
            {

                //List<MembershipUserCollection> user = Membership.GetAllUsers();

                var user = Membership.GetAllUsers().Cast<MembershipUser>().Where(u => u.IsApproved);

                //var users = from f in filtered
                //            join u in _db.Users on ((Guid)f.ProviderUserKey) equals u.MembershipGuid
                //            select u;

                //var usuarios = Membership.GetAllUsers();

                return View(user);
            }
            else
            {
                return RedirectToAction("LogOn", "Account");
            }
            //return View();
        }
        
        //
        // GET: /Administracao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Administracao/Edit/5
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
        // GET: /Administracao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Administracao/Delete/5
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
