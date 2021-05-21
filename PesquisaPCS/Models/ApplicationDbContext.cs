using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;


namespace PesquisaPCS.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Agrotoxico> Agrotoxicos { get; set; }
        public DbSet<Amostra> Amostras { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<Ficha_Agro> Fichas_Agro { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
