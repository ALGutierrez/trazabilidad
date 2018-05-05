using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Cosecha
    {
        [Key]
        public int Id_Cosecha { get; set; }
        [Required]
        public int Año { get; set; }
        [MaxLength(45)]
        public string Descripcion { get; set; }
    }
}