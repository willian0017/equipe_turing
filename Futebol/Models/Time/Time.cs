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
        public string Mascote { get; set; }
        public string Presidente { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}