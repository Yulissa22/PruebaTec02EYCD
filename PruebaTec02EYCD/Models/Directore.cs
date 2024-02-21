using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PruebaTec02EYCD.Models
{
    public partial class Directore
    {
        public Directore()
        {
            Peliculas = new HashSet<Pelicula>();
        }

        
        public int IdDirectores { get; set; }
        public string? Nombre { get; set; }
        public string? Nacionalidad { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
