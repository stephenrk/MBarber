using System.Web.Mvc;

namespace UNASP.MBarber.UI.Web.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}