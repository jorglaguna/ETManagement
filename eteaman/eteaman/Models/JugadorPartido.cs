using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("JugadoresPartido")]
    public class JugadorPartido
    {
        public long IdJugadorPartido { get; set; }

        public long IdPartido { get; set; }

        public virtual Partido Partido { get; set; }

        public int IdClub { get; set; }

        public virtual Club Club { get; set; }

        public int? Goles { get; set; }

        public decimal? Calificacion { get; set; }

        public int? IdAmonestacion { get; set; }

        public virtual Amonestacion Amonestacion { get; set; }

        public DateTime? FechaUltMod { get; set; }

        public string IdUsuarioUltMod { get; set; }

        public virtual ApplicationUser UsuarioUltMod { get; set; }
    }
}