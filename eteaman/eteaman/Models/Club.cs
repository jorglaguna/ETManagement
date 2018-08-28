using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("Clubs")]
    public class Club
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClub { get; set; }

        [Required]
        public string Nombre { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Web { get; set; }

        public string RutaEscudo { get; set; }

        public DateTime? FechaUltMod { get; set; }

        public string IdUsuarioUltMod { get; set; }

        public virtual ApplicationUser UsuarioUltMod { get; set; }

        public virtual List<ClubCompeticion> CompeticionesClub { get; set; }

        public virtual List<Partido> Partidos { get; set; }

        public virtual List<Jugador> Jugadores { get; set; }
    }
}