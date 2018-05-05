using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Datos_Recepcion
    {
        [Key]
        public int Id_DatosRecepcion { get; set; }
        [Required]
        public int Planta { get; set; }

        [Required]
        public int Id_Cosecha { get; set; }
        [ForeignKey("Id_Cosecha")]
        public Cosecha Cosecha { get; set; }

        [Required]
        public int Id_Gramaje { get; set; }
        [ForeignKey("Id_Gramaje")]
        public Gramaje Gramaje { get; set; }

        [Required]
        public int Id_Envase { get; set; }
        [ForeignKey("Id_Envase")]
        public Envase Envase { get; set; }
    }
}