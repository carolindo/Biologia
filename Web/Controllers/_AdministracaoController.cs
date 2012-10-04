using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Web.Controllers
{
    public class _AdministracaoController : Controller
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
        // GET: /Administracao/Usuarios
        public ActionResult Usuarios()
        {
            if (Request.IsAuthenticated)
            {
                MembershipUserCollection listaUsuarios = Membership.GetAllUsers();

                return View(listaUsuarios);
            }
            else
            {
                return RedirectToAction("LogOn", "Account");
            }
        }

    }
}
