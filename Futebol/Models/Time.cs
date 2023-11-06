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

        public Time()
        {
            this.Endereco = new Endereco();
            this.Jogadores = new List<Jogador>();
            this.Tecnico = new Tecnico();
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Nome};{this.AnoFundacao};{this.Endereco};{this.Tecnico.ToString()};{this.ListJogadores()}";
        }

        private string ListJogadores()
        {
            string lista = "";

            foreach (var jogador in this.Jogadores)
            {
                lista += $"{jogador.Nome};{jogador.Sobrenome};{jogador.AnoNascimento};{jogador.Numero}";
            }

            return lista;
        }
    }
}