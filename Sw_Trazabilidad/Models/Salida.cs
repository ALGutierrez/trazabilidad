using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Salida
    {
        [Key]
        public int Codigo_Salida { get; set; }

        [Required]
        [MaxLength(45)]
        public string LoteSalida { get; set; }

        [MaxLength(45)]
        public string Descripcion_salida { get; set; }

        [Required]
        public int Id_Producto { get; set; }
        [ForeignKey("Id_Producto")]
        public Producto Producto { get; set; }
    }
}