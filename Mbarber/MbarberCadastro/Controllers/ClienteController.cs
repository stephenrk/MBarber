using UNASP.Projeto.DTO;
using UNASP.Projeto.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbarberCadastro.Models;

namespace MbarberCadastro.Controllers
{
    public class ClienteController : Controller
    {
        BusinessCliente BusinessCliente = new BusinessCliente();

        [HttpGet]
        public ActionResult ListClientes()
        {
            var retorno = BusinessCliente.GetAllClientes(null);
            return Json(retorno, JsonRequestBehavior.AllowGet);

        }

        public ActionResult NewJavaScript(string Id)
        {
            Cliente cliente = new Cliente();
            if (Id != null)
            {
                cliente = BusinessCliente.GetById(Id);
            }
            return View(cliente);
        }

        public ActionResult IndexJavaScript()
        {
            return View();
        }

        public ActionResult ListClientesJson(string CliNome)
        {
            var cliente = new Cliente { CliNome = CliNome };
            var retorno = BusinessCliente.GetAllClientes(cliente);
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteJson(Cliente c)
        {
            var resposta = new RespostaHtml { success = true };
            try
            {
                BusinessCliente.Delete(c.CLiCPF);
                resposta.message = "Excluido com sucesso!";
            }
            catch (Exception ex)
            {
                resposta.success = false;
                ex = ErrorException(ex);
                resposta.message = ex.Message;
            }

            return Json(resposta, JsonRequestBehavior.DenyGet);
        }

        public ActionResult Delete(Cliente c)
        {
            ViewBag.Message = "O Registro foi excluido com sucesso";

            try
            {
                BusinessCliente.Delete(c.CLiCPF);
            }
            catch (Exception ex)
            {
                return View("Error", ErrorException(ex));
            }

            return View("New", new Cliente());
        }

        public ActionResult Edit(string id)
        {
            // Recupere o item do banco de dados
            var employee = BusinessCliente.GetById(id);
            if (employee == null)
            {
                var ex = new Exception("Registro Não Encontrado");
                return View("Erro", ex);
            }

            // retorne a View "New", passando como parametro o registro 
            // retornado do banco de dados
            return View("New", employee);
        }

        public ActionResult Teste()
        {
            return View();
        }

        // GET: 
        public ActionResult Index()
        {
            BusinessCliente BusinessCliente = new BusinessCliente();
            var retorno = BusinessCliente.GetAllClientes(null);
            return View(retorno);
        }

        public ActionResult New()
        {

            return View("New", new Cliente());
        }

        public System.Exception ErrorException(System.Exception ex)
        {
            if (ex.InnerException == null)
                return ex;
            else
                return ErrorException(ex.InnerException);
        }


        // Esse método deve responder com JSON e não View
        [HttpPost]
        public ActionResult SaveJson(Cliente c)
        {
            var resposta = new RespostaHtml { success = false };

            try
            {
                BusinessCliente.Save(c);
                resposta.Data = c;
                resposta.success = true;
            }
            catch (Exception ex)
            {
                ex = ErrorException(ex);
                resposta.message = ex.Message;
            }

            return Json(resposta, JsonRequestBehavior.DenyGet);
        }

        [HttpPost]
        public ActionResult Save(Cliente e)
        {
            try
            {
                BusinessCliente.Save(e);
            }
            catch (Exception ex)
            {
                ex = ErrorException(ex);
                return View("Error", ex);
            }

            // Se não ocorrer um erro, o que acontece?
            ViewBag.Message = "O Registro Foi Salvo com Sucesso!";
            return View("New", new Cliente());
        }

        
    }
}