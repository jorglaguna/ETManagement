using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("TiposCompeticion")]
    public class TipoCompeticion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoCompeticion { get; set; }

        public string Nombre { get; set; }
    }
}