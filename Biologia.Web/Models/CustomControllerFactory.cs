using System;
using System.Web.Mvc;
using System.Web.Routing;
using Biologia.Web.Controllers;
using Biologia.Data;

namespace Biologia.Web
{
    class CustomControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == typeof(InscricaoController))
                return new InscricaoController(new SqlInscricaoRepository("BiologiaDB", ""));
            return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}
