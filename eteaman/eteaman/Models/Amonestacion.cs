using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eteaman.Models
{
    [Table("Amonestaciones")]
    public class Amonestacion
    {
        public int IdAmonestacion { get; set; }

        public string Nombre { get; set; }
    }
}