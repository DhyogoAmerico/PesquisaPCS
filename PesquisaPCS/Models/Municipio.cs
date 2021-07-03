using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PesquisaPCS.Models
{
    public class Municipio
    {
        [Key]
        public int Idmunicipio { get; set; }
        public string Nome_municipio { get; set; }

        


    }
}
