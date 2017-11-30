using Coletti.DAO;
using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coletti.Controllers
{
    public class OrcamentoController : Controller
    {
        // GET: Orcamento
        public ActionResult Index()
        {
            var dao = new OrcamentosDAO();
            var orcamentos = dao.Lista();
            return View(orcamentos);
        }
        public ActionResult Form()
        {
            ViewBag.Prioridade = new PrioridadesDAO().Lista();
            return View(new PedidosDAO().Lista());
        }
        public ActionResult Adiciona(Orcamento orcamento, string carro)
        {
            var dao = new OrcamentosDAO();
            var pedido = new PedidosDAO().BuscaPorId(Convert.ToInt32(carro));
            dao.Adiciona(orcamento);
            pedido.OrcamentoId = orcamento.Id;
            new PedidosDAO().Atualiza(pedido);
            return RedirectToAction("Index", "Orcamento");
        }

        //public JsonResult AddOrcamento(int IdOrcamento, int IdPedido)
        //{
        //    var dao = new PedidosDAO();
        //    var pedido = dao.BuscaPorId(IdPedido);
        //    pedido.OrcamentoId = IdOrcamento;
        //    dao.Atualiza(pedido);
        //}
    }
}