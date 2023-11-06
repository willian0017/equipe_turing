using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;
using equipe_turing.Futebol.Services;

namespace equipe_turing.Futebol.View
{
    public class ViewJogador
    {
        public void getCrudJogador()
        {
            CrudJogador crudJogador = new CrudJogador();
            Jogador jogador = new Jogador();
            Console.WriteLine("Você escolheu: Jogador");
            Console.Write("O que deseja fazer?\n1 - Criar\n2 - Editar\n3 - Remover\n4 - Ler\n");

            string condicao = Console.ReadLine();

            if (condicao == "1")
            {
                Console.WriteLine("Digite seu nome.");
                jogador.Nome = Console.ReadLine();

                Console.WriteLine("Digite seu sobrenome.");
                jogador.Sobrenome = Console.ReadLine();

                Console.WriteLine("Digite sua ano de nascimento.");
                jogador.AnoNascimento = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu número.");
                jogador.Numero = byte.Parse(Console.ReadLine());

                crudJogador.Create(jogador);
            }
            else if (condicao == "2")
            {
                Console.WriteLine("Digite o ID que você deseja alterar.");
                jogador.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu nome.");
                jogador.Nome = Console.ReadLine();

                Console.WriteLine("Digite seu sobrenome.");
                jogador.Sobrenome = Console.ReadLine();

                Console.WriteLine("Digite sua ano de nascimento.");
                jogador.AnoNascimento = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu número.");
                jogador.Numero = byte.Parse(Console.ReadLine());

                crudJogador.Update(jogador);
            }
            else if (condicao == "3")
            {
                Console.WriteLine("Digite o ID que você deseja deletar.");
                jogador.Id = int.Parse(Console.ReadLine());

                crudJogador.Delete(jogador.Id);
            }
            else if (condicao == "4")
            {
                var jogadores = crudJogador.Read();
                jogadores.ToList().ForEach(x => Console.WriteLine(x));
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}