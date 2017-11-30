using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class MensagensDAO
    {
        public void Adiciona(Mensagem mensagem)
        {
            using (var context = new ColettiContext())
            {
                context.Mensagens.Add(mensagem);
                context.SaveChanges();
            }
        }

        public IList<Mensagem> Lista()
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Mensagens.ToList();
            }
        }

        public Mensagem BuscaPorId(int id)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Mensagens.Find(id);
            }
        }

        public void Atualiza(Mensagem mensagem)
        {
            using (var contexto = new ColettiContext())
            {
                contexto.Entry(mensagem).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}