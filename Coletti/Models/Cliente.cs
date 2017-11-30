using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string RazaoSocial { get; set; }
    }

}