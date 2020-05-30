using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "O campo senha precisa ter no mínimo 6 caracteres")]
        public string Senha { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public int IdTipoUsuario { get; set; }

        public TipoUsuarioDomain TipoUsuario { get; set; }
    }
}
