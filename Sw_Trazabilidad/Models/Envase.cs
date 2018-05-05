using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Envase
    {
        [Key]
        public int Id_Envase { get; set; }
        [Required]
        [MaxLength(45)]
        public string Nombre_Tipo { get; set; }

        [MaxLength(45)]
        public string Descripcion { get; set; }
    }
}