using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaPCS.Models
{
    interface IFichaAgroRepositorio
    {
        IQueryable<Ficha_Agro> FichasAgro { get; }

        public void Create(Ficha_Agro ficha);
        public Ficha_Agro ObterFicha(int id);
        public void Edit(Ficha_Agro ficha);
        public void Delete(Ficha_Agro ficha);
    }
}
