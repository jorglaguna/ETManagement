using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("Posiciones")]
    public class Posicion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPosicion { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Abreviatura { get; set; }
    }
}