using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaPCS.Models
{
    interface IAmostraRepositorio
    {
        IQueryable<Amostra> Amostras { get; }

        public void Create(Amostra amostra);
        public Amostra ObterAmostra(int id);
        public void Edit(Amostra amostra);
        public void Delete(Amostra amostra);
    }
}
