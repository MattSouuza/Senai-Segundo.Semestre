using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Domains
{
    [Table("TipoUsuarios")]
    public class TipoUsuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoUsuario { get; set; }

        [Column("Titulo")]
        [Required(ErrorMessage = "O nome do papel precisa ser informado")]
        public string Titulo { get; set; }
    }
}
