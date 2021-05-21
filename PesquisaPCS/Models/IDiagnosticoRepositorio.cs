using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaPCS.Models
{
    interface IDiagnosticoRepositorio
    {
        IQueryable<Diagnostico> Diagnosticos { get; }

        public void Create(Diagnostico diagnostico);
        public Diagnostico ObterDiagnostico(int id);
        public void Edit(Diagnostico diagnostico);
        public void Delete(Diagnostico diagnostico);
    }
}
