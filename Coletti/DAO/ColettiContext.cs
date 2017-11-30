using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Coletti.DAO
{
    public class ColettiContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }   
        public DbSet<Prioridade> Prioridades { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<Remetente> Remetentes { get; set; }

        public ColettiContext() : base("Server=(localdb)\\mssqllocaldb;Database=AndreDB;Trusted_Connection=true;")
        {

        }
    }
}