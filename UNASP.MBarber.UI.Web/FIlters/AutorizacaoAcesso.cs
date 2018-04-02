using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace UNASP.MBarber.UI.Web.Filters
{
    public class AutorizacaoAcesso : AuthorizeAttribute
    {
        public static bool IsPermission
        {
            get
            {
                return ((Login)HttpContext.Current.Session["UsuarioLogado"]) != null;
            }
        }
    }
}