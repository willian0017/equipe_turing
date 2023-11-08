using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;
using equipe_turing.Futebol.Services;

namespace equipe_turing.Futebol.View
{
    public class ViewTime
    {
        public void getCrudTime()
        {
            CrudTime crudTime = new CrudTime();
            Time time = new Time();
            Console.WriteLine("Você escolheu: Time");
            Console.Write("O que deseja fazer?\n1 - Criar\n2 - Editar\n3 - Remover\n4 - Ler\n");

            string condicao = Console.ReadLine();

            if (condicao == "1")
            {
                inserirDados(time);
                crudTime.Create(time);
            }
            else if (condicao == "2")
            {
                obterId(time);
                inserirDados(time);
                crudTime.Update(time);
            }
            else if (condicao == "3")
            {
                obterId(time);
                crudTime.Delete(time.Id);
            }
            else if (condicao == "4")
            {
                var times = crudTime.Read();
                times.ToList().ForEach(x => Console.WriteLine(x));
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }

        private void obterId(Time time)
        {
            Console.WriteLine("Digite o ID");
            time.Id = int.Parse(Console.ReadLine());
        }

        private void  inserirDados(Time time)
        {
            Console.WriteLine("Digite o nome do time");
            time.Nome = Console.ReadLine();

            Console.WriteLine("Digite o ano de fundação.");
            time.AnoFundacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua cidade");
            time.Endereco.Cidade = Console.ReadLine();

            Console.WriteLine("Digite seu estado");
            time.Endereco.Estado = Console.ReadLine();

            Console.WriteLine("Digite o número");
            time.Endereco.Numero = int.Parse(Console.ReadLine());

            Jogador jogador = new Jogador();

            Console.WriteLine("Digite o nome do jogador");
            jogador.Nome = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do jogador");
            jogador.Sobrenome = Console.ReadLine();

            Console.WriteLine("Digite o ano de nascimento do jogador");
            jogador.AnoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do jogador");
            jogador.Numero = byte.Parse(Console.ReadLine());

            time.Jogadores.Add(jogador);

            Console.WriteLine("Digite o nome do técnico");
            time.Tecnico.Nome = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do técnico");
            time.Tecnico.Sobrenome = Console.ReadLine();

            Console.WriteLine("Digite o ano de nascimento do técnico");
            time.Tecnico.AnoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o estilo de jogo do técnico");
            time.Tecnico.EstiloDeJogo = Console.ReadLine();
        }
    }
}