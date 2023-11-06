using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace equipe_turing.Futebol.Models
{
    public class Jogador : Pessoa
    {
        public byte Numero { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{this.Numero}";
        }
    }
}