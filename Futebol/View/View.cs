using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;
using equipe_turing.Futebol.Services;

namespace equipe_turing.Futebol.View
{
    public class View
    {
        public void Main()
        {
            string continuar;
            do
            {
                Console.WriteLine("Digite um valor: (1) Jogador");
                Console.WriteLine("Digite um valor: (2) Tecnico");
                Console.WriteLine("Digite um valor: (3) Time");
                Console.WriteLine("Digite um valor: (4) Endereco");

                string var = Console.ReadLine();

                switch (var)
                {
                    case "1":
                        getCrudJogador();
                        break;
                    case "2":
                        getCrudTecnico();
                        break;
                    case "3":
                        getCrudTime();
                        break;
                    case "4":
                        getCrudEndereco();
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        break;
                }

                Console.Write("Deseja Continuar (Sim/Não): ");
                continuar = Console.ReadLine();
            } while (continuar.ToLower() == "sim");
        }
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
        public void getCrudTecnico()
        {
            CrudTecnico crudTecnico = new CrudTecnico();
            Tecnico tecnico = new Tecnico();
            Console.WriteLine("Você escolheu: Técnico");
            Console.Write("O que deseja fazer?\n1 - Criar\n2 - Editar\n3 - Remover\n4 - Ler\n");

            string condicao = Console.ReadLine();

            // if (condicao == "1")
            // {
            //     crudTecnico.Create(tecnico);
            // }
            // else if (condicao == "2")
            // {
            //     crudTecnico.Update(tecnico);
            // }
            // else if (condicao == "3")
            // {
            //     crudTecnico.Delete(tecnico.Id);
            // }
            // else if (condicao == "4")
            // {
            //     var tecnicoes = crudTecnico.Read();
            //     tecnicoes.ForEach(x => Console.WriteLine(x));
            // }
            // else
            // {
            //     Console.WriteLine("Opção inválida");
            // }
        }

        public void getCrudTime()
        {
            CrudTime crudTime = new CrudTime();
            Time time = new Time();
            Console.WriteLine("Você escolheu: Matéria");
            Console.Write("O que deseja fazer?\n1 - Criar\n2 - Editar\n3 - Remover\n4 - Ler\n");

            string condicao = Console.ReadLine();

            if (condicao == "1")
            {
                Console.WriteLine("Digite o nome do time");
                time.Nome = Console.ReadLine();

                Console.WriteLine("Digite o ano de fundação.");
                time.AnoFundacao = int.Parse(Console.ReadLine());
            
                // Como salvar uma composição e ler 
                Console.WriteLine("Digite seu endereço");
                time.Endereco = Console.ReadLine();

                crudTime.Create(time);
            }
            else if (condicao == "2")
            {
                crudTime.Update(time);
            }
            else if (condicao == "3")
            {
                crudTime.Delete(time.Id);
            }
            else if (condicao == "4")
            {
                var times = crudTime.Read();
                times.ForEach(x => Console.WriteLine(x));
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
        public void getCrudEndereco()
        {
            CrudEndereco crudEndereco = new CrudEndereco();
            Endereco endereco = new Endereco();
            Console.WriteLine("Você escolheu: Endereco");
            Console.Write("O que deseja fazer?\n1 - Criar\n2 - Editar\n3 - Remover\n4 - Ler\n");

            string condicao = Console.ReadLine();

            // if (condicao == "1")
            // {
            //     crudEndereco.Create(endereco);
            // }
            // else if (condicao == "2")
            // {
            //     crudEndereco.Update(endereco);
            // }
            // else if (condicao == "3")
            // {
            //     crudEndereco.Delete(endereco.Id);
            // }
            // else if (condicao == "4")
            // {
            //     // var enderecos = crudEndereco.Read();
            //     // endereco.ForEach(x => Console.WriteLine(x));
            // }
            // else
            // {
            //     Console.WriteLine("Opção inválida");
            // }
        }
    }
}