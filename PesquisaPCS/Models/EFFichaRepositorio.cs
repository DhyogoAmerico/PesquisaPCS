using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PesquisaPCS.Models
{
    public class EFFichaRepositorio : IFichaRepositorio
    {
        public ApplicationDbContext context;

        public EFFichaRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Ficha> Fichas => context.Fichas;

        public void Create(Ficha ficha)
        {
            context.Add(ficha);
            context.SaveChanges();
        }

        public void Delete(Ficha ficha)
        {
            context.Remove(ficha);
            context.SaveChanges();
        }

        public void Edit(Ficha ficha)
        {
            context.Entry(ficha).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Ficha ObterFicha(int id)
        {
            var ficha = context.Fichas
                .FirstOrDefault(a => a.Idficha == id);
            return ficha;
        }
    }
}
