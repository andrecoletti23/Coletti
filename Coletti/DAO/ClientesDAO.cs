using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class ClientesDAO
    {
        public void Adiciona(Cliente cliente)
        {
            using (var context = new ColettiContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        public IList<Cliente> Lista()
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Clientes.ToList();
            }
        }

        public Cliente BuscaPorId(int id)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Clientes.Find(id);
            }
        }

        public void Atualiza(Cliente cliente)
        {
            using (var contexto = new ColettiContext())
            {
                contexto.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public Cliente Busca(string login, string senha)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Clientes.FirstOrDefault(u => u.Login == login && u.Senha == senha);
            }
        }
    }
}