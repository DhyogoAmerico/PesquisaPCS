using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PesquisaPCS.Models
{
    public class Ficha_Agro
    {
        [Key]
        public int Idficha_agro { get; set; }
        public int Idficha { get; set; }
        public int Idproduto { get; set; }
        


    }
}
