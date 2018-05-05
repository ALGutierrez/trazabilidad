using Sw_Trazabilidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sw_Trazabilidad.Controllers
{
    
    public class AdministracionController : Controller
    {
        private readonly Contexto db = new Contexto();
        // GET: Administracion
        public ActionResult NuevaMateriaPrima()
        {
            return View();
        }

        public ActionResult NuevoProducto()
        {
            return View();
        }

        public ActionResult NuevoTipoMateriaP()
        {
            return View();
        }

        public ActionResult NuevaCosecha()
        {
            return View();
        }

        public ActionResult NuevoGramaje()
        {
            return View();
        }

        public ActionResult NuevoEnvase()
        {
            return View();
        }

        [HttpPost]

        public ActionResult NuevoProducto(string NombreProd, string Descripcion)
        {
            Producto producto = new Producto()
            {
                Nombre = NombreProd,
                Descripcion = Descripcion
            };

            db.Productos.Add(producto);
            db.SaveChanges();
            return View();
        }

        public ActionResult NuevoTipoMateriaP(string NombreTMateriaP, string Descripcion)
        {
            Tipo_MateriaPrima tipo = new Tipo_MateriaPrima()
            {
                Nombre = NombreTMateriaP,
                Descripcion = Descripcion
            };

            db.TiposMateriaPrima.Add(tipo);
            db.SaveChanges();
            return View();
        }

        public ActionResult NuevaCosecha(int AñoCosecha, string Descripcion)
        {
            Cosecha nuevaCosecha = new Cosecha()
            {
                Año = AñoCosecha,
                Descripcion = Descripcion
            };

            db.Cosechas.Add(nuevaCosecha);
            db.SaveChanges();
            return View();
        }

        public ActionResult NuevoGramaje(int PesoGramaje, string Descripcion)
        {
            Gramaje gramaje = new Gramaje()
            {
                Peso = PesoGramaje,
                Descripcion = Descripcion
            };

            db.Gramajes.Add(gramaje);
            db.SaveChanges();
            return View();
        }

        public ActionResult NuevoEnvase(string NombreEnvase, string Descripcion)
        {
            Envase envase = new Envase()
            {
                Nombre_Tipo = NombreEnvase,
                Descripcion = Descripcion
            };

            db.Envases.Add(envase);
            db.SaveChanges();
            return View();
        }
    }
}