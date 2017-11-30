using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coletti.Models
{
    public class Orcamento
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime DataEntregaSugerida { get; set; }
        public Prioridade Prioridade { get; set; }
        public int PrioridadeId { get; set; }
    }
}