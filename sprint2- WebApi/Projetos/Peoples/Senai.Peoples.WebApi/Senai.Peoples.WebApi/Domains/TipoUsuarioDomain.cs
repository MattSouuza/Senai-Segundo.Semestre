using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class TipoUsuarioDomain
    {
        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O nome precisa ser informado")]
        public string TituloTipoUsuario { get; set; }

        //[Required(ErrorMessage = "Informe o e-mail")]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "Informe a senha")]
        //[DataType(DataType.Password)]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "O campo senha precisa ter no mínimo 3 caracteres")]
        //public string Senha { get; set; }

        //[ForeignKey("IdTipoUsuario")]
        //public int IdTipoUsuario { get; set; }
    }
}
