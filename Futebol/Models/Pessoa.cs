using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace equipe_turing.Futebol.Models
{
    public class Pessoa : BaseModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int AnoNascimento { get; set; }

        public override string ToString()
        {
            return $"{this.Id}; {this.Nome}; {this.Sobrenome}; {this.AnoNascimento};";
        }
    }
}