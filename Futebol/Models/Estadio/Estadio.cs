using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace equipe_turing.Futebol.Models
{
    public class Estadio
    {
        public string Nome { get; set; }
        public int AnoFundacao { get; set; }
        public string Capacidade { get; set; }
        public Endereco endereco { get; set; }
    }
}