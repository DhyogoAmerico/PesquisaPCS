using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PesquisaPCS.Models
{
    public class Agrotoxico
    {
        [Key]
        public int Idagrotoxico { get; set; }
        public string Nome_agrotoxico { get; set; }
        public string Tipo_agrotoxico { get; set; }
        public string Principio_ativo { get; set; }
    }
}
