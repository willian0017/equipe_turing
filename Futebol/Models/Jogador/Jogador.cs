using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace equipe_turing.Futebol.Models
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public byte Numero { get; set; }
        public int AnoNascimento { get; set; }
    }
}