using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaPCS.Models
{
    interface IPacienteRepositorio
    {
        IQueryable<Paciente> Pacientes { get; }

        public void Create(Paciente paciente);
        public Paciente ObterPaciente(int id);
        public void Edit(Paciente paciente);
        public void Delete(Paciente paciente);
    }
}
