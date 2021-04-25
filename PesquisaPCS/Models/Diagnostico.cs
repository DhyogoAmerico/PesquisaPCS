using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PesquisaPCS.Models
{
    public class Diagnostico
    {
        [Key]
        public int Iddiagnostico { get; set; }
        [Key]
        public string Sigla_diagnostico { get; set; }
        public string Descricao_diagnostico { get; set; }
    }
}
