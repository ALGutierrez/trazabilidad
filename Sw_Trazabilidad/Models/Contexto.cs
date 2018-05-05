using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sw_Trazabilidad.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base(nameOrConnectionString:"traza")
        {

        }

        public DbSet<Cosecha> Cosechas { get; set; }
        public DbSet<Datos_Recepcion> DatosRecepcion { get; set; }
        public DbSet<Empresa_Proveedor> EmpresasProveedores { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Envase> Envases { get; set; }
        public DbSet<Gramaje> Gramajes { get; set; }
        public DbSet<Linea_Producto> LineasProductos { get; set; }
        public DbSet<Materia_Prima> MateriasPrimas { get; set; }
        public DbSet<Proceso> Procesos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Salida> Salidas { get; set; }
        public DbSet<Tipo_MateriaPrima> TiposMateriaPrima { get; set; }
    }
}