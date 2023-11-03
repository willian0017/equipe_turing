using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace equipe_turing.Futebol.Models
{
    public class Time : BaseModel
    {
        public string Nome { get; set; }
        public int AnoFundacao { get; set; }
        public Endereco Endereco { get; set; }
        public List<Jogador> Jogadores { get; set; }
        public Tecnico Tecnico { get; set; }
    }
}