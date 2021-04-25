using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaPCS.Models
{
    interface IFichaRepositorio
    {
        IQueryable<Ficha> Fichas { get; }

        public void Create(Ficha ficha);
        public Ficha ObterFicha(int id);
        public void Edit(Ficha ficha);
        public void Delete(Ficha ficha);
    }
}
