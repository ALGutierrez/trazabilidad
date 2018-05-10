using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    [Table("Procesos")]
    public class Proceso
    {
        [Key]
        public int Id_Proceso { get; set;}
        [Required]
        [MaxLength(45)]
        public string Nombre { get; set;}
        [Required]
        public bool Es_Recepcion { get; set;}
        [Required]
        public DateTime Fecha_Actividad { get; set;}
        [Required]
        public int Cantidad { get; set;}
        [Required]
        [MaxLength(45)]
        public string Observaciones { get; set; }

        [Required]
        public int Codigo_Entrada { get; set; }
        [ForeignKey("Codigo_Entrada")]
        public Entrada Entrada { get; set; }

        [Required]
        public int Codigo_Salida { get; set; }
        [ForeignKey("Codigo_Salida")]
        public Salida Salida { get; set; }


        public int? Id_DatosRecepcion { get; set; }
        [ForeignKey("Id_DatosRecepcion")]
        public Datos_Recepcion DatosRecepcion { get; set; }
    }
}