using Sw_Trazabilidad.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var tiposMP = db.TiposMateriaPrima.ToList();
            ViewBag.TiposMP = tiposMP;
            return View();
        }

        public ActionResult NuevoProducto()
        {
            var mp = db.MateriasPrimas.ToList();
            ViewBag.MPrimas = mp;
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
        public ActionResult NuevaMateriaPrima(string NombreMP, string DescripcionGral, int selectTipos)
        {
            var tipo = db.TiposMateriaPrima.Find(selectTipos);
            Materia_Prima mp = new Materia_Prima()
            {
                Nombre = NombreMP,
                Descripcion_Gral = DescripcionGral,
                TipoMateriaPrima = tipo
            };
            db.MateriasPrimas.Add(mp);
            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public ActionResult NuevoProducto(string NombreProd, string Descripcion, List<Materia_Prima> materiasPrimas)
        {
            Producto producto = new Producto()
            {
                Nombre = NombreProd,
                Descripcion = Descripcion,
                LineasProducto = new List<Linea_Producto>()
            };
            db.Productos.Add(producto);

            foreach (var materia in materiasPrimas)
            {
                Linea_Producto linea = new Linea_Producto
                {
                    IdMateria_Prima = materia.IdMateria_Prima,
                    Id_Producto = producto.Id_Producto
                };
                db.LineasProductos.Add(linea);
            }
            db.SaveChanges();
            var mp = db.MateriasPrimas.ToList();
            ViewBag.MPrimas = mp;
            return View();
        }

        [HttpPost]
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

        [HttpPost]
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

        [HttpPost]
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

        [HttpPost]
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