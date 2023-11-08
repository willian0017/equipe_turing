using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;
using equipe_turing.Futebol.Services;

namespace equipe_turing.Futebol.View
{
    public class ViewTecnico
    {
        public void getCrudTecnico()
        {
            CrudTecnico crudTecnico = new CrudTecnico();
            Tecnico tecnico = new Tecnico();
            Console.WriteLine("Você escolheu: Técnico");
            Console.Write("O que deseja fazer?\n1 - Criar\n2 - Editar\n3 - Remover\n4 - Ler\n");

            string condicao = Console.ReadLine();

            if (condicao == "1")
            {
                inserirDados(tecnico);
                crudTecnico.Create(tecnico);
            }
            else if (condicao == "2")
            {
                obterId(tecnico);
                inserirDados(tecnico);
                crudTecnico.Update(tecnico);
            }
            else if (condicao == "3")
            {
                obterId(tecnico);
                crudTecnico.Delete(tecnico.Id);
            }
            else if (condicao == "4")
            {
                var tecnicoes = crudTecnico.Read();
                tecnicoes.ToList().ForEach(x => Console.WriteLine(x));
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }

        private void obterId(Tecnico tecnico)
        {
            Console.WriteLine("Digite o Id");
            tecnico.Id = int.Parse(Console.ReadLine());
        }

        private void inserirDados(Tecnico tecnico)
        {
            Console.WriteLine("Digite seu nome.");
            tecnico.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome.");
            tecnico.Sobrenome = Console.ReadLine();

            Console.WriteLine("Digite seu ano de nascimento.");
            tecnico.AnoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu estilo de jogo.");
            tecnico.EstiloDeJogo = Console.ReadLine();
        }
    }
}