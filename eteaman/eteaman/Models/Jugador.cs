using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("Jugadores")]
    public class Jugador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdJugador { get; set; }

        [Required]
        public string Nick { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Telefono { get; set; }

        public string Dni { get; set; }

        public int? IdPosicionPrincipal { get; set; }

        public virtual Posicion PosicionPrincipal { get; set; }

        public int? IdPosicionSecundaria { get; set; }

        public virtual Posicion PosicionSecundaria { get; set; }

        public int IdClub { get; set; }

        public virtual Club Club { get; set; }

        public DateTime? FechaUltMod { get; set; }

        public string IdUsuarioUltMod { get; set; }

        public virtual ApplicationUser UsuarioUltMod { get; set; }

        public virtual List<JugadorPartido> PartidosJugador { get; set; }
    }
}