using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Gramaje
    {
        [Key]
        public int Id_Gramaje { get; set; }
        [Required]
        public int Peso { get; set; }
        [MaxLength(45)]
        public string Descripcion { get; set; }
    }
}