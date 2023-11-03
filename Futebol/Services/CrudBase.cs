using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;

namespace equipe_turing.Futebol.Services
{
    internal class CrudBase<B> : ICrud<B> where B : BaseModel
    {
        public void Create(B model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<B> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(B model)
        {
            throw new NotImplementedException();
        }
    }
}