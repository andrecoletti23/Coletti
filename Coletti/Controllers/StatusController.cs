using Coletti.DAO;
using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coletti.Controllers
{
    public class StatusController : Controller
    {
        // GET: Statusaa
        public ActionResult Index()
        {
            return View(new StatusDAO().Lista());
        }

        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Adiciona(Status status)
        {            
            new StatusDAO().Adiciona(status);
            return RedirectToAction("Index");
        }
    }
}