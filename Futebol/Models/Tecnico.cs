using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace equipe_turing.Futebol.Models
{
    public class Tecnico : Pessoa
    {
        public string EstiloDeJogo { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Estilo de jogo: {this.EstiloDeJogo}";
        }

    }
}