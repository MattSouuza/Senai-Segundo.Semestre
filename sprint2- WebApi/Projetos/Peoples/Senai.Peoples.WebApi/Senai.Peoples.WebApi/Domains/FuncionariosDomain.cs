using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class FuncionariosDomain
    {
        public int IdFuncionario { get; set; }
        [Required(ErrorMessage = "O nome precisa ser informado")]
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; } 
    }
}
