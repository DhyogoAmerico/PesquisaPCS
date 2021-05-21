using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PesquisaPCS.Models
{
    public class EFFichaAgroRepositorio : IFichaAgroRepositorio
    {
        public ApplicationDbContext context;

        public EFFichaAgroRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Ficha_Agro> FichasAgro => context.Fichas_Agro;

        public void Create(Ficha_Agro ficha)
        {
            context.Add(ficha);
            context.SaveChanges();
        }

        public void Delete(Ficha_Agro ficha)
        {
            context.Remove(ficha);
            context.SaveChanges();
        }

        public void Edit(Ficha_Agro ficha)
        {
            context.Entry(ficha).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Ficha_Agro ObterFicha(int id)
        {
            var ficha = context.Fichas_Agro
                .FirstOrDefault(a => a.Idficha_agro == id);
            return ficha;
        }
    }
}
