using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
 
namespace Coletti.Filtros
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        { 
            object usuarioCliente = filterContext.HttpContext.Session["clienteLogado"];
            object usuarioFuncionario = filterContext.HttpContext.Session["clienteLogado"];
            if (usuarioCliente == null || usuarioFuncionario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Login", action = "Index" }  
                    )
                );
            }
        }
    }
}