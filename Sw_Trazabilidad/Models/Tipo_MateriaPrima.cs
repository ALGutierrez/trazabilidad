using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Tipo_MateriaPrima
    {
        [Key]
        public int IdTipo_MateriaPrima { get; set; }

        [Required]
        [MaxLength(45)]
        public string Nombre { get; set; }

        [MaxLength(45)]
        public string Descripcion { get; set; }

        public virtual ICollection<Materia_Prima> MateriasPrimas { get; set; }
    }
}