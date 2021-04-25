using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PesquisaPCS.Models
{
    public class EFDiagnosticoRepositorio : IDiagnosticoRepositorio
    {
        public ApplicationDbContext context;

        public EFDiagnosticoRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Diagnostico> Diagnosticos => context.Diagnosticos;
        public void Create(Diagnostico diagnostico)
        {
            context.Add(diagnostico);
            context.SaveChanges();
        }

        public void Delete(Diagnostico diagnostico)
        {
            context.Remove(diagnostico);
            context.SaveChanges();
        }

        public void Edit(Diagnostico diagnostico)
        {
            context.Entry(diagnostico).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Diagnostico ObterDiagnostico(int id)
        {
            var diag = context.Diagnosticos
                .FirstOrDefault(a => a.Iddiagnostico == id);
            return diag;
        }
    }
}
