using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaPCS.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context =
           app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Municipios.Any())
            {
                context.Municipios.AddRange(
                new Municipio
                {
                    Nome_municipio = "Alfenas"
                },
                new Municipio
                {
                    Nome_municipio = "Alterosa"
                },
                new Municipio
                {
                    Nome_municipio = "Areado"
                },
                new Municipio
                {
                    Nome_municipio = "Fama"
                },
                new Municipio
                {
                    Nome_municipio = "Machado"
                },
                new Municipio
                {
                    Nome_municipio = "Serrania"
                });

                context.SaveChanges();
            }
        }
    }
}
