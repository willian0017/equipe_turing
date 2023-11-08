using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;

namespace equipe_turing.Futebol.Services
{
    class CrudTecnico : CrudBase<Tecnico>
    {
        public override void Delete(int id)
        {
            List<Tecnico> tecnicos = Read().ToList();
            Tecnico tecnico = tecnicos.Find(x => x.Id == id);

            if (tecnico != null)
            {
                tecnicos.Remove(tecnico);
                StreamWriter Writer = new StreamWriter("./Futebol/Banco/Tecnico.txt");

                foreach (var tecnicoAtual in tecnicos)
                {
                    Writer.WriteLine(tecnicoAtual.ToString());
                }
                Writer.Close();
            }
        }

        public override IEnumerable<Tecnico> Read()
        {
            StreamReader reader = new StreamReader("./Futebol/Banco/Tecnico.txt");
            List<Tecnico> tecnicos = new List<Tecnico>();
            string linha = reader.ReadLine();

            while (linha != null)
            {
                var tecnico = linha.Split(';');
                Tecnico model = new Tecnico { Id = Convert.ToInt32(tecnico[0]), Nome = tecnico[1], Sobrenome = tecnico[2], AnoNascimento = Convert.ToInt32(tecnico[3]), EstiloDeJogo = tecnico[4] };
                tecnicos.Add(model);
                linha = reader.ReadLine();
            }

            reader.Close();
            return tecnicos;
        }

        public override void Update(Tecnico model)
        {
            List<Tecnico> lista = Read().ToList();
            Tecnico tecnico = lista.Find(x => x.Id == model.Id);

            if (tecnico != null)
            {
                tecnico.Nome = model.Nome;
                tecnico.Sobrenome = model.Sobrenome;
                tecnico.AnoNascimento = model.AnoNascimento;
                tecnico.EstiloDeJogo = model.EstiloDeJogo;

                StreamWriter Writer = new StreamWriter("./Futebol/Banco/Tecnico.txt");

                foreach (var tecnicoAtual in lista)
                {
                    Writer.WriteLine(tecnicoAtual.ToString());
                }

                Writer.Close();

            }
        }
    }
}