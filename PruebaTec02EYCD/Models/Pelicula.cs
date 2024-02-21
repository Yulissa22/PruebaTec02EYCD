using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PruebaTec02EYCD.Models
{
    public partial class Pelicula
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; } = null!;
        public byte[]? Imagen { get; set; }
        public string? Sinopsis { get; set; }
        [DisplayName("Año Lanzamiento")]
        public int? AnioLanzamiento { get; set; }
        public string? Genero { get; set; }
        [DisplayName("Directores")]
        public int? IdDirectores { get; set; }

        [DisplayName("Directores")]
        public virtual Directore? IdDirectoresNavigation { get; set; }
    }
}
