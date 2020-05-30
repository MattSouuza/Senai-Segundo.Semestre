using System;
using System.Collections.Generic;

namespace DataBaseFirst2.Domains
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? IdTipoUsuario { get; set; }

        public TipoUsuarios IdTipoUsuarioNavigation { get; set; }
    }
}
