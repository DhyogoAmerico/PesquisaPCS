using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaPCS.Models
{
    interface IAgrotoxicoRepositorio
    {
        IQueryable<Agrotoxico> Agrotoxicos { get; }

        public void Create(Agrotoxico agrotoxico);
        public Agrotoxico ObterAgrotoxico(int id);
        public void Edit(Agrotoxico agrotoxico);
        public void Delete(Agrotoxico agrotoxico);
    }
}
