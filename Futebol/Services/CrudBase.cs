using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;

namespace equipe_turing.Futebol.Services
{
    internal class CrudBase<B> : ICrud<B> where B : BaseModel
    {
        private static int proximoId;
        public void Create(B model)
        {
            proximoId++;
            model.Id = proximoId;
            var modelName = model.GetType().Name;

            StreamWriter Writer = new StreamWriter($"./Futebol/Banco/{modelName}.txt", true);
            string linha = model.ToString();

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

        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<B> Read()
        {
            throw new NotImplementedException();
        }

        public virtual void Update(B model)
        {
            throw new NotImplementedException();
        }
    }
}