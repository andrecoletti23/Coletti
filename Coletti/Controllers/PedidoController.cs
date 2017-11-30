using Coletti.DAO;
using Coletti.Filtros;
using Coletti.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coletti.Controllers
{
    [AutorizacaoFilter]
    public class PedidoController : Controller
    {
        // GET: Pedido
        public ActionResult Index()
        {
            var dao = new PedidosDAO();
            var pedidos = dao.Lista();
            IList orcamentos = new List<Orcamento>();
            foreach (var pedido in pedidos)
            {
                if (pedido.ClienteId == ((Cliente)(Session["clienteLogado"])).Id & pedido.OrcamentoId != 0)
                {
                    orcamentos.Add(new OrcamentosDAO().BuscaPorId(pedido.OrcamentoId));                    
                }
            }
            ViewBag.Orcamento = orcamentos;
            return View(pedidos);
        }

        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Adiciona(Pedido pedido)
        {
            var dao = new PedidosDAO();            
            pedido.DataRealizado = DateTime.Now;
            pedido.ClienteId = ((Cliente)(Session["clienteLogado"])).Id;
            pedido.StatusId = 1;
            dao.Adiciona(pedido);
            return RedirectToAction("Index");
        }
        public ActionResult Remove(int id) {
            PedidosDAO dao = new PedidosDAO();
            Pedido pedido = dao.BuscaPorId(id);
            dao.Remove(pedido);
            return Json(pedido);
        }
    }
}