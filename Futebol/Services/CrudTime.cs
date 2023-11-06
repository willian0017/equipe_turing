using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;

namespace equipe_turing.Futebol.Services
{
    public class CrudTime
    {
        private static int proximoId;

        public void Create(Time  model)
        {
            model.Id = proximoId++;
            string linha = JsonSerializer.Serialize(model);

            StreamWriter Writer = new StreamWriter("./Futebol/Banco/Time.txt", true);

            try
            {
                Writer.WriteLine(linha);
                Writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Delete(int id)
        {
            List<Time> times = Read().ToList();
            Time time = times.Find(x => x.Id == id);

            if (time != null)
            {
                times.Remove(time);
                StreamWriter Writer = new StreamWriter("./Futebol/Banco/Time.txt");

                foreach (var timeAtual in times)
                {
                    Writer.WriteLine(timeAtual.ToString());
                }
                Writer.Close();
            }
        }

        public IEnumerable<Time> Read()
        {
            StreamReader reader = new StreamReader("./Futebol/Banco/Time.txt");
            List<Time> times = new List<Time>();
            string linha = reader.ReadLine();

            while (linha != null)
            {
                var time = linha.Split(';');

                // Time model = new Time { Id = Convert.ToInt32(time[0]), Nome = time[1], AnoFundacao = Convert.ToInt32(time[2]), Endereco = time[3], Jogadores = time[4], Tecnico = time[5] };
                // times.Add(model);
                linha = reader.ReadLine();
            }
            reader.Close();
            return times;
        }

        public void Update(Time model)
        {
            List<Time> lista = Read().ToList();
            Time time = lista.Find(x => x.Id == model.Id);

            if (time != null)
            {
                time.Nome = model.Nome;
                time.AnoFundacao = model.AnoFundacao;
                time.Endereco = model.Endereco;
                time.Jogadores = model.Jogadores;
                time.Tecnico = model.Tecnico;

                StreamWriter Writer = new StreamWriter("./Futebol/Banco/Time.txt");

                foreach (var timeAtual in lista)
                {
                    Writer.WriteLine(timeAtual.ToString());
                }

                Writer.Close();

            }
        }
    }
}