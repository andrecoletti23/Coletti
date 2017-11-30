using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.Models
{
    public class Pedido
    {
        public int id { get; set; }
        public string Descricao { get; set; }
        public int StatusId { get; set; }
        public DateTime DataRealizado { get; set; }
        public DateTime DataEntregaDesejada { get; set; }
        public int ClienteId { get; set; }
        public int OrcamentoId { get; set; }
        public string Imagem { get; set; }
    }
}