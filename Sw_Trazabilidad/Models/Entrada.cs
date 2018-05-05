using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Entrada
    {
        [Key]
        public int Codigo_Entrada { get; set;}

        [MaxLength(45)]
        public string descripcion_entrada { get; set;}

        public int? Codigo_Salida { get; set; }
        [ForeignKey("Codigo_Salida")]
        public Salida Salida { get; set; }

        [Required]
        public int IdMateria_Prima { get; set; }
        [ForeignKey("IdMateria_Prima")]
        public Materia_Prima MateriaPrima { get; set; }
    }
}