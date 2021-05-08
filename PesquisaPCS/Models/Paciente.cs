using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PesquisaPCS.Models
{
    public class Paciente
    {
        [Key]
        public int Idpaciente { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }

        //public int Idmunicipio_residencia { get; set; }
        //[Column("Idmunicipio_residencia", TypeName = "ntext")]
        public Municipio Residencia { get; set; }

        public string Zona_residencia { get; set; }
        public char Sexo { get; set; }

        //especificar formato da data [25/04/2021]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data_nascimento { get; set; }
        public int Escolaridade { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        public ICollection<Ficha> Fichas { get; set; }
    }
}
