using AutoMapper;
using System.Web.Mvc;
using UNASP.MBarber.Common;
using UNASP.MBarber.DataAccess;
using UNASP.MBarber.Repository;
using UNASP.MBarber.UI.Web.Filters;
using UNASP.MBarber.UI.Web.ViewModels;

namespace UNASP.MBarber.UI.Web.Controllers
{
    [RoutePrefix("acesso-ao-sistema")]
    public class LoginController : Controller
    {

        #region Repository

        private LoginRepository loginRepository;

        public LoginController()
        {
            this.loginRepository = new LoginRepository();
        }

        #endregion

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autenticar(string email, string senha)
        {
            // Verifica se o estado do modelo está válido
            if (ModelState.IsValid)
            {
                // Criptografa a senha inserida pelo usuário
                var senhaCripto = Criptografia.CriptografaMd5(senha);

                // Mapper serve para fazer a ponte das propriedades do DTO para as propriedades do dominio que representa o BD
                // Aqui chamamos a lógica de autenticação e retornamos o usuário a ser logado
                var validarAcesso = Mapper.Map<Login, LoginModel>(loginRepository.AutenticarAcesso(email, senhaCripto));

                // Se não achar o usuário, devolve erro
                // Se achar, adiciona ele na session e cria o cookie
                if (validarAcesso == null)
                {
                    ViewBag.Error = true;
                    ModelState.AddModelError("login.Invalido", "Usuário ou senha inválido!");
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
            System.Web.Security.FormsAuthentication.SignOut();
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
        public ActionResult CriarAcesso(LoginModel dadosRegistro)
        {
            if (ModelState.IsValid)
            {
                var verificarExistenciaEmail = loginRepository.BuscarPorEmail(dadosRegistro.Email);

                if (verificarExistenciaEmail != null)
                {
                    ModelState.AddModelError("login.invalido", "Esse e-mail já está sendo utilizado, por favor, utilize um e-mail alternativo");
                    return View(dadosRegistro);
                }
                else
                {
                    var registroDominio = Mapper.Map<LoginModel, Login>(dadosRegistro);
                    
                    loginRepository.Inserir(registroDominio);

                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View(dadosRegistro);
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