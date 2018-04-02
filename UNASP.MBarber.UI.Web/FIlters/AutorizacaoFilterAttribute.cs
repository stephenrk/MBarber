using System.Web.Mvc;
using System.Web.Routing;

namespace UNASP.MBarber.UI.Web.Filters
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object usuarioLogado = filterContext.HttpContext.Session["UsuarioLogado"];

            if (usuarioLogado == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "login",
                    action = "Index"
                }));
            }
        }
    }
}