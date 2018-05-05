using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Linea_Producto
    {
        [Key]
        public int Id_LineaProducto { get; set; }

        [Required]
        public int IdMateria_Prima { get; set; }
        [ForeignKey("IdMateria_Prima")]
        public Materia_Prima Materiaprima { get; set; }

        [Required]
        public int Id_Producto { get; set; }
        [ForeignKey("Id_Producto")]
        public Producto Producto { get; set; }
    }
}