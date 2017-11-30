using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class RemetentesDAO
    {
        public void Adiciona(Remetente remetente)
        {
            using (var context = new ColettiContext())
            {
                context.Remetentes.Add(remetente);
                context.SaveChanges();
            }
        }

        public IList<Remetente> Lista()
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Remetentes.ToList();
            }
        }

        public Remetente BuscaPorId(int id)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Remetentes.Find(id);
            }
        }

        public void Atualiza(Remetente remetente)
        {
            using (var contexto = new ColettiContext())
            {
                contexto.Entry(remetente).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}