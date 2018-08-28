using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("ClubsCompeticion")]
    public class ClubCompeticion
    {
        [Key, Column(Order = 1)]
        public int IdCompeticion { get; set; }

        public virtual Competicion Competicion { get; set; }

        [Key, Column(Order = 2)]
        public int IdClub { get; set; }

        public virtual Club Club { get; set; }
    }
}