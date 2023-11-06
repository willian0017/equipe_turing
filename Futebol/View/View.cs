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

                string var = Console.ReadLine();

                switch (var)
                {
                    case "1":
                        ViewJogador viewJogador = new ViewJogador();
                        viewJogador.getCrudJogador();
                        break;
                    case "2":
                        ViewTecnico viewTecnico = new ViewTecnico();
                        viewTecnico.getCrudTecnico();
                        break;
                    case "3":
                        ViewTime viewTime = new ViewTime();
                        viewTime.getCrudTime();
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        break;
                }

                Console.Write("Deseja Continuar (Sim/Não): ");
                continuar = Console.ReadLine();

            } while (continuar.ToLower() == "sim");
        }
    }
}