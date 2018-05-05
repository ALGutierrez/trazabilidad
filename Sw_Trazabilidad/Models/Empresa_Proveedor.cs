using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Empresa_Proveedor
    {
        [Key]
        public int IdEmpresa_Proveedor { get; set; }
        [Required]
        [MaxLength(45)]
        public string RazonSocial { get; set; }
        [Required]
        [MaxLength(45)]
        public string CUIT { get; set; }
        [Required]
        [MaxLength(45)]
        public string Direccion { get; set; }
    }
}