using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class OrcamentosDAO
    {
        public void Adiciona(Orcamento orcamento)
        {
            using (var context = new ColettiContext())
            {
                context.Orcamentos.Add(orcamento);
                context.SaveChanges();
            }
        }

        public IList<Orcamento> Lista()
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Orcamentos.ToList();
            }
        }

        public Orcamento BuscaPorId(int id)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Orcamentos.Find(id);
            }
        }

        public void Atualiza(Orcamento orcamento)
        {
            using (var contexto = new ColettiContext())
            {
                contexto.Entry(orcamento).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}