﻿using System;
using System.Collections.Generic;

namespace DataBaseFirst2.Domains
{
    public partial class Estudios
    {
        public Estudios()
        {
            Jogos = new HashSet<Jogos>();
        }

        public int IdEstudio { get; set; }
        public string NomeEstudio { get; set; }

        public ICollection<Jogos> Jogos { get; set; }
    }
}
