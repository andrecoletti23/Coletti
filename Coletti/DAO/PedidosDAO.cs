using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class PedidosDAO
    {
        public void Adiciona(Pedido pedidos)
        {
            using (var context = new ColettiContext())
            {
                context.Pedidos.Add(pedidos);
                context.SaveChanges();
            }
        }

        public IList<Pedido> Lista()
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Pedidos.ToList();
            }
        }

        public Pedido BuscaPorId(int id)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Pedidos.Find(id);
            }
        }

        public void Atualiza(Pedido pedidos)
        {
            using (var contexto = new ColettiContext())
            {
                contexto.Entry(pedidos).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Remove(Pedido pedidos)
        {
            using (var contexto = new ColettiContext())
            {
                contexto.Entry(pedidos).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}