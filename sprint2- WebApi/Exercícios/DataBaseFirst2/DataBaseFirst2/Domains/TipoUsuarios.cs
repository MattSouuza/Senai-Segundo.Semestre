using System;
using System.Collections.Generic;

namespace DataBaseFirst2.Domains
{
    public partial class TipoUsuarios
    {
        public TipoUsuarios()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdTipoUsuario { get; set; }
        public string TituloTipoUsuario { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
