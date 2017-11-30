using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class PrioridadesDAO
    {
        public void Adiciona(Prioridade prioridade)
        {
            using (var context = new ColettiContext())
            {
                context.Prioridades.Add(prioridade);
                context.SaveChanges();
            }
        }

        public IList<Prioridade> Lista()
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Prioridades.ToList();
            }
        }

        public Prioridade BuscaPorId(int id)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Prioridades.Find(id);
            }
        }

        public void Atualiza(Prioridade prioridade)
        {
            using (var contexto = new ColettiContext())
            {
                contexto.Entry(prioridade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}