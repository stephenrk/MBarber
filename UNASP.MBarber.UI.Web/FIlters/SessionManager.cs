using System.Web;
using UNASP.MBarber.UI.Web.Models;

namespace UNASP.MBarber.UI.Web.Filters
{
    public class SessionManager
    {
        public static LoginModel UsuarioLogado
        {
            set
            {

                HttpContext.Current.Session.Add("UsuarioLogado", value);
            }
            get
            {
                return (LoginModel)HttpContext.Current.Session["UsuarioLogado"];
            }

        }

        public static bool IsAuthenticated
        {
            get
            {
                return ((LoginModel)HttpContext.Current.Session["UsuarioLogado"]) != null;
            }
        }
    }
}