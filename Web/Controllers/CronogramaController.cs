using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class CronogramaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult dezesseis()
        {
            return View("dezesseis", "_Layout2");
        }

        public ActionResult dezessete()
        {
            return View("dezessete", "_Layout2");
        }

        public ActionResult dezoito()
        {
            return View("dezoito", "_Layout2");
        }

        public ActionResult dezenove()
        {
            return View("dezenove", "_Layout2");
        }

        public ActionResult vinte()
        {
            return View("vinte", "_Layout2");
        }

        public ActionResult vinteUm()
        {
            return View("VinteUm", "_Layout2");
        }
    }
}
