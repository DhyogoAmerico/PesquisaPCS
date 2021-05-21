using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PesquisaPCS.Models
{
    public class EFAgrotoxicoRepositorio: IAgrotoxicoRepositorio
    {
        public ApplicationDbContext context;

        public EFAgrotoxicoRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Agrotoxico> Agrotoxicos => context.Agrotoxicos;

        public void Create(Agrotoxico agrotoxico)
        {
            context.Add(agrotoxico);
            context.SaveChanges();
        }

        public void Delete(Agrotoxico agrotoxico)
        {
            context.Remove(agrotoxico);
            context.SaveChanges();
        }

        public void Edit(Agrotoxico agrotoxico)
        {
            context.Entry(agrotoxico).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Agrotoxico ObterAgrotoxico(int id)
        {
            var agrotoxico = context.Agrotoxicos
               .FirstOrDefault(a => a.Idagrotoxico == id);
            return agrotoxico;
        }
    }
}
