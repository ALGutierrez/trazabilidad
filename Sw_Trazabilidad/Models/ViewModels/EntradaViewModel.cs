using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models.ViewModels
{
    public class EntradaViewModel
    {
        public int IdMateriaPrima { get; set; }
        public int IdProveedor { get; set; }
        public string Lote { get; set; }
    }
}