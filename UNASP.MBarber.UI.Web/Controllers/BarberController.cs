using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using UNASP.MBarber.Repository;
using UNASP.MBarber.Repository.ConnectionContext;
using UNASP.MBarber.UI.Web.Models;

namespace UNASP.MBarber.UI.Web.Controllers
{
    public class BarberController : Controller
    {
        private readonly BarberRepository repository = new BarberRepository();

        // GET: Barber
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Novo()
        {
            var tiposServicos = Mapper.Map<IEnumerable<TipoServico>, IEnumerable<TipoServicoModel>>(repository.ListarTiposServicos());
            ViewBag.TiposServicos = tiposServicos;

            return View();
        }
    }
}