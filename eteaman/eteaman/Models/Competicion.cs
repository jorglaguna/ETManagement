using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("Competiciones")]
    public class Competicion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdCompeticion { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string PersonaContacto { get; set; }

        [EmailAddress]
        public string EmailContacto { get; set; }

        public string Web { get; set; }

        public string RutaIcono { get; set; }

        public int IdTipoCompeticion { get; set; }

        public virtual TipoCompeticion TipoCompeticion { get; set; }

        public DateTime? FechaUltMod { get; set; }

        public string IdUsuarioUltMod { get; set; }

        public virtual ApplicationUser UsuarioUltMod { get; set; }

        public virtual List<Temporada> Temporadas { get; set; }

        public virtual List<ClubCompeticion> ClubesCompeticion { get; set; }

        public virtual List<Partido> Partidos { get; set; }
    }
}