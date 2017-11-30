using Coletti.DAO;
using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coletti.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login 
        public ActionResult Index()
        {
            return View(); 
        }

        public ActionResult Autentica(String login, String senha)
        {
            ClientesDAO daoCliente = new ClientesDAO();
            Cliente usuarioCliente = daoCliente.Busca(login, senha);
            FuncionariosDAO daoFuncionario = new FuncionariosDAO();
            Funcionario usuarioFuncionario = daoFuncionario.Busca(login, senha);
             if (usuarioCliente != null)
            {
                Session["clienteLogado"] = usuarioCliente;
                return RedirectToAction("Index", "Home");
            } else if (usuarioFuncionario != null)
            {
                Session["funcionarioLogado"] = usuarioFuncionario;
                return RedirectToAction("Index", "Home");
            }
            else{
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult Logout()
        {            
            Session["clienteLogado"] = null;
            Session["funcionarioLogado"] = null;
            return RedirectToAction("Index", "Home");                   
        }
    }
}