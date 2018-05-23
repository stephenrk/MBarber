using System;
using System.Web.Mvc;
using UNASP.MBarber.Repository;

namespace UNASP.MBarber.UI.Web.Controllers
{
    public class ImagemController : Controller
    {
        ImagemRepository repository = new ImagemRepository();

        public ActionResult Show(Guid id)
        {
            var imageData = repository.BuscarPorId(id).Picture;

            return File(imageData, "image/jpg");
        }
    }
}