using AutoMapper;
using System;
using System.Web.Mvc;
using UNASP.MBarber.Common;
using UNASP.MBarber.DataAccess;
using UNASP.MBarber.DataTransferObject;
using UNASP.MBarber.Repository;
using UNASP.MBarber.UI.Web.Filters;

namespace UNASP.MBarber.UI.Web.Controllers
{
    [RoutePrefix("acesso-ao-sistema")]
    public class LoginController : Controller
    {
        private LoginRepository loginRepository;

        public LoginController()
        {
            this.loginRepository = new LoginRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autenticar(string email, string senha)
        {
            if (ModelState.IsValid)
            {
                var senhaCripto = Criptografia.CriptografaMd5(senha);

                Mapper.Initialize(cfg => {
                    cfg.CreateMap<Login, LoginDTO>();
                });
                var validarAcesso = Mapper.Map<Login, LoginDTO>(loginRepository.AutenticarAcesso(email, senhaCripto));

                if (validarAcesso == null)
                {
                    ViewBag.Error = true;
                    ModelState.AddModelError("login.Invalido", "Usuário ou senha Inválido, tente novamente!");
                }
                else
                {
                    SessionManager.UsuarioLogado = validarAcesso;
                    System.Web.Security.FormsAuthentication.SetAuthCookie(validarAcesso.Email, true);

                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("login.Invalido", "Preencha o campo com login e senha!");
            }

            return View("Index");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Session.RemoveAll();
            return View("Index");
        }

        [ClaimsAuthorize("CriarAcesso", "CA")]
        public ActionResult CriarAcesso()
        {
            return View();
        }

        [HttpPost]
        [Route("novo-acesso")]
        [ClaimsAuthorize("CriarAcesso", "CA")]
        [ValidateAntiForgeryToken]
        public ActionResult CriarAcesso([Bind(Include = "Id,Email,Senha")] LoginDTO login)
        {
            if (ModelState.IsValid)
            {
                var verificarExistenciaEmail = loginRepository.BuscarPorEmail(login.Email);

                if (verificarExistenciaEmail == null)
                {
                    ModelState.AddModelError("login.invalido", "Esse e-mail já está sendo utilizado, por favor, utilize um e-mail alternativo");
                    return View(login);
                }
                else
                {
                    var loginDomain = Mapper.Map<LoginDTO, Login>(login);

                    loginDomain.DataInclusao = DateTime.Now;
                    loginDomain.Senha = Criptografia.CriptografaMd5(login.Senha);

                    loginRepository.Inserir(loginDomain);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View(login);
            }
        }

        [ClaimsAuthorize("ListarAcesso", "LTA")]
        public ActionResult ListarAcesso()
        {
            var usuarios = loginRepository.ObterTodos();
            return View(usuarios);
        }
    }
}