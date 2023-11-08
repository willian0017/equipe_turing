using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;

namespace equipe_turing.Futebol.Services
{
    class CrudJogador : CrudBase<Jogador>
    {
        public override void Delete(int id)
        {
            List<Jogador> jogadores = Read().ToList();
            Jogador jogador = jogadores.Find(x => x.Id == id);

            if (jogador != null)
            {
                jogadores.Remove(jogador);
                StreamWriter Writer = new StreamWriter("./Futebol/Banco/Jogador.txt");

                foreach (var jogadorAtual in jogadores)
                {
                    Writer.WriteLine(jogadorAtual.ToString());
                }
                Writer.Close();
            }
        }

        public override IEnumerable<Jogador> Read()
        {
            StreamReader reader = new StreamReader("./Futebol/Banco/Jogador.txt");
            List<Jogador> jogadores = new List<Jogador>();
            string linha = reader.ReadLine();

            while (linha != null)
            {
                var jogador = linha.Split(';');
                Jogador model = new Jogador { Id = Convert.ToInt32(jogador[0]), Nome = jogador[1], Sobrenome = jogador[2], AnoNascimento = Convert.ToInt32(jogador[3]), Numero = Convert.ToByte(jogador[4]) };
                jogadores.Add(model);
                linha = reader.ReadLine();
            }
            
            reader.Close();
            return jogadores;
        }

        public override void Update(Jogador model)
        {
            List<Jogador> lista = Read().ToList();
            Jogador jogador = lista.Find(x => x.Id == model.Id);

            if (jogador != null)
            {
                jogador.Nome = model.Nome;
                jogador.Sobrenome = model.Sobrenome;
                jogador.AnoNascimento = model.AnoNascimento;
                jogador.Numero = model.Numero;

                StreamWriter Writer = new StreamWriter("./Futebol/Banco/Jogador.txt");

                foreach (var jogadorAtual in lista)
                {
                    Writer.WriteLine(jogadorAtual.ToString());
                }

                Writer.Close();

            }
        }
    }
}