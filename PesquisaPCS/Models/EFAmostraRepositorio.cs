using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PesquisaPCS.Models
{
    public class EFAmostraRepositorio : IAmostraRepositorio
    {
        public ApplicationDbContext context;

        public EFAmostraRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Amostra> Amostras => context.Amostras;


        public void Create(Amostra amostra)
        {
            context.Add(amostra);
            context.SaveChanges();
        }

        public void Delete(Amostra amostra)
        {
            context.Remove(amostra);
            context.SaveChanges();
        }

        public void Edit(Amostra amostra)
        {
            context.Entry(amostra).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Amostra ObterAmostra(int id)
        {
            var amostra = context.Amostras
               .FirstOrDefault(a => a.IdAmostra == id);
            return amostra;
        }
    }
}
