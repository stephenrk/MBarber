using AutoMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using UNASP.MBarber.Repository;
using UNASP.MBarber.Repository.ConnectionContext;
using UNASP.MBarber.UI.Web.Models;

namespace UNASP.MBarber.UI.Web.Controllers
{
    public class BarberController : Controller
    {
        private readonly BarberRepository barberRepository = new BarberRepository();

        // GET: Barber
        public ActionResult Index()
        {
            var empresas = Mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaModel>>(barberRepository.ListarBarbearias());

            return View(empresas);
        }

        public ActionResult Novo()
        {
            var tiposServicos = Mapper.Map<IEnumerable<TipoServico>, IEnumerable<TipoServicoModel>>(barberRepository.ListarTiposServicos());
            ViewBag.TiposServicos = tiposServicos;

            return View();
        }

        [HttpPost]
        public ActionResult Novo(EmpresaModel dadosRegistro, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                dadosRegistro.Imagem = new ImagemModel
                {
                    Picture = new byte[file.ContentLength],
                    ContentType = file.ContentType,
                    Description = "Descricao Imagem",
                    Length = file.ContentLength
                };
                file.InputStream.Read(dadosRegistro.Imagem.Picture, 0, file.ContentLength);

                var registroDominio = Mapper.Map<EmpresaModel, Empresa>(dadosRegistro);

                barberRepository.Inserir(registroDominio);

                return RedirectToAction("Index");
            }
            else
            {
                return View(dadosRegistro);
            }
        }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            try
            {
                var memStream = new MemoryStream();
                file.InputStream.CopyTo(memStream);

                byte[] fileData = memStream.ToArray();

                //save file to database using fictitious repository
                //var repo = new FictitiousRepository();
                //repo.SaveFile(file.FileName, fileData);
            }
            catch (Exception exception)
            {
                return Json(new
                {
                    success = false,
                    response = exception.Message
                });
            }

            return Json(new
            {
                success = true,
                response = "File uploaded."
            });
        }
    }
}