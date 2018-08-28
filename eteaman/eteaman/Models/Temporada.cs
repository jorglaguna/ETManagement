using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("Temporadas")]
    public class Temporada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTemporada { get; set; }

        [Required]
        public int Ano { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime? FechaUltMod { get; set; }

        public string IdUsuarioUltMod { get; set; }

        public virtual ApplicationUser UsuarioUltMod { get; set; }

        public long IdCompeticion { get; set; }

        public virtual Competicion Competicion { get; set; }
    }
}