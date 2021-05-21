using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaPCS.Models
{
    interface IMunicipioRepositorio
    {
        IQueryable<Municipio> Municipios { get; }
        public void Create(Municipio municipio);
        public Municipio ObterMunicipio(int id);
        public void Edit(Municipio municipio);
        public void Delete(Municipio municipio);
    }
}
