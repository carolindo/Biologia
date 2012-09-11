using System.Collections.Generic;
using System.Web.Mvc;
using Biologia.Domain;
using System.Web.Routing;

namespace Biologia.Controllers
{
    public class MenuController : Controller
    {
        public ViewResult MenuSuperior()
        {
            var aba = Request.RequestContext.RouteData.Values["controller"] as string;
            var navLinks = new List<NavLink>();

            navLinks.Add(MontaMenu(aba, "Home", "Home", "Index"));

            if (User.Identity.IsAuthenticated)
                navLinks.Add(MontaMenu(aba, "Lista Inscricaos", "Inscricao", "Index"));
            else
                navLinks.Add(MontaMenu(aba, "Inscrições", "Inscricao", "Create"));

            navLinks.Add(MontaMenu(aba, "Sobre Evento", "Sobre", "Sobre"));
            navLinks.Add(MontaMenu(aba, "Cronograma de Palestras", "Cronograma", "Cronograma"));

            if (User.Identity.IsAuthenticated)
                navLinks.Add(MontaMenu(aba, "Administração", "Inscricao", "Index"));
            else
                navLinks.Add(MontaMenu(aba, "Administração", "Account", "LogOn"));

            return View(navLinks);
        }

        /// <summary>
        /// Monta o menu superior.
        /// </summary>
        /// <param name="current">Controller da página atual</param>
        /// <param name="nomeMenu">Nome do menu</param>
        /// <param name="controller">Controller referente ao menu</param>
        /// <param name="action">Action de destino do menu</param>
        /// <returns></returns>
        public NavLink MontaMenu(string current, string nomeMenu, string controller, string action)
        {
            return new NavLink
            {
                IsSelected = ((current == controller) || current == action),
                Text = nomeMenu,
                RouteValue = new RouteValueDictionary(
                    new
                    {
                        controller = controller,
                        action = action,
                    })
            };
        }
    }
}
