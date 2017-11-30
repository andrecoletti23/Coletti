using Coletti.DAO;
using Coletti.Filtros;
using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coletti.Controllers
{
    [AutorizacaoFilter]
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            var dao = new FuncionariosDAO();
            var funcionarios = dao.Lista();
            return View(funcionarios);
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Adiciona(Funcionario funcionario)
        {
            var dao = new FuncionariosDAO();
            dao.Adiciona(funcionario);
            return RedirectToAction("Index");
        }
    }
}