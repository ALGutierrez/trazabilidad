using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Materia_Prima
    {
        [Key]
        public int IdMateria_Prima { get; set; }
        [Required]
        [MaxLength(45)]
        public string Nombre { get; set; }

        [MaxLength(45)]
        public string Descripcion_Gral { get; set; }

        [Required]
        public int IdTipo_MateriaPrima { get; set; }
        [ForeignKey("IdTipo_MateriaPrima")]
        public Tipo_MateriaPrima TipoMateriaPrima { get; set; }

        public virtual ICollection<Linea_Producto> LineasProducto { get; set; }
        public virtual ICollection<Empresa_Proveedor> EmpresasProveedores { get; set; }
    }
}