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
    }
}