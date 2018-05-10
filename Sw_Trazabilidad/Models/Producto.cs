using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int Id_Producto { get; set; }
        [Required]
        [MaxLength(45)]
        public string Nombre { get; set; }
        [MaxLength(45)]
        public string Descripcion { get; set; }

        public virtual ICollection<Linea_Producto> LineasProducto { get; set; }
    }
}