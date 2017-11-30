using Coletti.DAO;
using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coletti.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {

            return View(new ClientesDAO().Lista());
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Adiciona(Cliente cliente)
        {
            var dao = new ClientesDAO();
            dao.Adiciona(cliente);
            return RedirectToAction("Index", "Home");
        }
    }
}