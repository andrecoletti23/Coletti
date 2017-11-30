using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.Models
{
    public class Mensagem
    {
        public int id { get; set; }
        public string Descricao { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataEnvio { get; set; }
        public int RemetenteId { get; set; }
    }
}