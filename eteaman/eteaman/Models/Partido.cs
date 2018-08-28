using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("Partidos")]
    public class Partido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdPartido { get; set; }

        public long IdCompeticion { get; set; }

        public virtual Competicion Competicion { get; set; }

        public int IdClubLocal { get; set; }

        public virtual Club ClubLocal { get; set; }

        public int IdClubVisitante { get; set; }

        public virtual Club ClubVisitante { get; set; }

        public int GolesLocal { get; set; }

        public int GolesVisitante { get; set; }

        public string Anotaciones { get; set; }

        public DateTime? FechaUltMod { get; set; }

        public string IdUsuarioUltMod { get; set; }

        public virtual ApplicationUser UsuarioUltMod { get; set; }

        public virtual List<JugadorPartido> JugadoresPartido { get; set; }


    }
}