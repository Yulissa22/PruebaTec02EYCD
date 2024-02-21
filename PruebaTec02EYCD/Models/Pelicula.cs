using System;
using System.Collections.Generic;

namespace PruebaTec02EYCD.Models
{
    public partial class Pelicula
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; } = null!;
        public byte[]? Imagen { get; set; }
        public string? Sinopsis { get; set; }
        public int? AnioLanzamiento { get; set; }
        public string? Genero { get; set; }
        public int? IdDirectores { get; set; }

        public virtual Directore? IdDirectoresNavigation { get; set; }
    }
}
