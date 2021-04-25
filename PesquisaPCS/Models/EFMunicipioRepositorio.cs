using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PesquisaPCS.Models
{
    public class EFMunicipioRepositorio : IMunicipioRepositorio
    {
        public ApplicationDbContext context;

        public EFMunicipioRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Municipio> Municipios => context.Municipios;

        public void Create(Municipio municipio)
        {
            context.Add(municipio);
            context.SaveChanges();
        }

        public void Delete(Municipio municipio)
        {
            context.Remove(municipio);
            context.SaveChanges();
        }

        public void Edit(Municipio municipio)
        {
            context.Entry(municipio).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Municipio ObterMunicipio(int id)
        {
            var municipio = context.Municipios
                 .FirstOrDefault(a => a.Idmunicipio == id);
            return municipio;
        }
    }
}
