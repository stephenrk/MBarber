using System.Web;
using UNASP.MBarber.DataTransferObject;

namespace UNASP.MBarber.UI.Web.Filters
{
    public class SessionManager
    {
        public static LoginDTO UsuarioLogado
        {
            set
            {

                HttpContext.Current.Session.Add("UsuarioLogado", value);
            }
            get
            {
                return (LoginDTO)HttpContext.Current.Session["UsuarioLogado"];
            }

        }

        public static bool IsAuthenticated
        {
            get
            {
                return ((LoginDTO)HttpContext.Current.Session["UsuarioLogado"]) != null;
            }
        }
    }
}