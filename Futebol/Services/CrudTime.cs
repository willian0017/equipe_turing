using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;

namespace equipe_turing.Futebol.Services
{
    class CrudTime : CrudBase<Time>
    {
        public override void Delete(int id)
        {
            List<Time> times = Read().ToList();
            Time time = times.Find(x => x.Id == id);

            if (time != null)
            {
                times.Remove(time);
                string linha = JsonSerializer.Serialize(times);
                StreamWriter Writer = new StreamWriter("./Futebol/Banco/Time.txt");

                Writer.WriteLine(linha);
                Writer.Close();
            }
        }

        public override IEnumerable<Time> Read()
        {
            StreamReader reader = new StreamReader("./Futebol/Banco/Time.txt");
            List<Time> times = new List<Time>();
            string linha = reader.ReadLine();

            while (linha != null)
            {
                var time = JsonSerializer.Deserialize<Time>(linha);
                Time model = new Time { Id = Convert.ToInt32(time.Id), Nome = time.Nome, AnoFundacao = Convert.ToInt32(time.AnoFundacao), Endereco = time.Endereco,  Tecnico = time.Tecnico};
                times.Add(model);
                linha = reader.ReadLine();
            }
            
            reader.Close();
            return times;
        }

        public override void Update(Time model)
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

                string linha = JsonSerializer.Serialize(time);
                StreamWriter Writer = new StreamWriter("./Futebol/Banco/Time.txt");
                Writer.WriteLine(linha);
                Writer.Close();
            }
        }
    }
}