using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class StatusDAO
    {
        public void Adiciona(Status status)
        {
            using (var context = new ColettiContext())
            {
                context.Status.Add(status);
                context.SaveChanges();
            }
        }

        public IList<Status> Lista()
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Status.ToList();
            }
        }

        public Status BuscaPorId(int id)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Status.Find(id);
            }
        }

        public void Atualiza(Status status)
        {
            using (var contexto = new ColettiContext())
            {
                contexto.Entry(status).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}