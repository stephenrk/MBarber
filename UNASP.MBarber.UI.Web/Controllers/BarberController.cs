using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UNASP.MBarber.UI.Web.Controllers
{
    public class BarberController : Controller
    {
        // GET: Barber
        public ActionResult Index()
        {
            return View();
        }
    }
}