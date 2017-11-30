using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class FuncionariosDAO
    {
        public void Adiciona(Funcionario funcionario)
        {
            using (var context = new ColettiContext())
            {
                context.Funcionarios.Add(funcionario);
                context.SaveChanges();
            }
        }

        public IList<Funcionario> Lista()
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Funcionarios.ToList();
            }
        }

        public Funcionario BuscaPorId(int id)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Funcionarios.Find(id);
            }
        }

        public void Atualiza(Funcionario funcionario)
        {
            using (var contexto = new ColettiContext())
            {
                contexto.Entry(funcionario).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public Funcionario Busca(string login, string senha)
        {
            using (var contexto = new ColettiContext())
            {
                return contexto.Funcionarios.FirstOrDefault(u => u.Login == login && u.Senha == senha);
            }
        }
    }
}