using System.Web.Mvc;

namespace Biologia.Web.Controllers
{
    public class CronogramaController : Controller
    {
        public ActionResult Cronograma()
        {
            return View();
        }

        public ActionResult Dezesseis()
        {
            return View("Dezesseis", "_Layout2");
        }

        public ActionResult Dezessete()
        {
            return View("Dezessete", "_Layout2");
        }

        public ActionResult Dezoito()
        {
            return View("Dezoito", "_Layout2");
        }

        public ActionResult Dezenove()
        {
            return View("Dezenove", "_Layout2");
        }

        public ActionResult Vinte()
        {
            return View("Vinte", "_Layout2");
        }
    }
}
