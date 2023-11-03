using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equipe_turing.Futebol.Models;

namespace equipe_turing.Futebol.Services
{
    internal interface ICrud<T> where T : BaseModel
    {
        void Create(T model);
        IEnumerable<T> Read();
        void Update(T model);
        void Delete(int id);
    }
}