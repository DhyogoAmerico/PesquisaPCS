using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PesquisaPCS.Models
{
    public class EFPacienteRepositorio : IPacienteRepositorio
    {
        public ApplicationDbContext context;

        public EFPacienteRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Paciente> Pacientes => context.Pacientes;

        public void Create(Paciente paciente)
        {
            context.Add(paciente);
            context.SaveChanges();
        }

        public void Delete(Paciente paciente)
        {
            context.Remove(paciente);
            context.SaveChanges();
        }

        public void Edit(Paciente paciente)
        {
            context.Entry(paciente).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Paciente ObterPaciente(int id)
        {
            var paciente = context.Pacientes
                .FirstOrDefault(a => a.Idpaciente == id);
            return paciente;
        }
    }
}
