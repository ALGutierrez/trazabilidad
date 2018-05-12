using Sw_Trazabilidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Sw_Trazabilidad.Controllers
{
    public class ProcesosController : Controller
    {
        private readonly Contexto db = new Contexto();
        // GET: Procesos
        public ActionResult NuevoProceso()
        {
            var productos = db.Productos.ToList();
            var proveedores = db.EmpresasProveedores.ToList();
            var cosechas = db.Cosechas.ToList();
            var gramajes = db.Gramajes.ToList();
            var envases = db.Envases.ToList();
            ViewBag.Proveedores = proveedores;
            ViewBag.Productos = productos;
            ViewBag.Cosechas = cosechas;
            ViewBag.Gramajes = gramajes;
            ViewBag.Envases = envases;
            return View();
        }

        [HttpPost]
        public ActionResult NuevoProceso(string hola)
        {
            return View();
        }


        [HttpPost]
        public ActionResult ObtenerMateriasPrimasPorProducto(int idProducto)
        {
            var materias_primas = db.LineasProductos.Include(x => x.Materiaprima)
                .Where(x => x.Id_Producto == idProducto).Select(x => new {Codigo = x.Materiaprima.IdMateria_Prima, Nombre = x.Materiaprima.Nombre}).ToList();
            return Json(materias_primas);
        }

        [HttpPost]
        public ActionResult ObtenerLotesPorLinea(int idMateriaPrima)
        {
            var lotes = db.Entradas.Include(x => x.MateriaPrima).Where(x => x.IdMateria_Prima == idMateriaPrima).Select(x => new {Id = x.Codigo_Entrada, Nombre = x.LoteEntrada }).ToList();
            var proveedores = db.EmpresasProveedores.Where(x => x.MateriasPrimas.Any(y => y.IdMateria_Prima == idMateriaPrima)).Select(x => new {Id = x.IdEmpresa_Proveedor, Nombre = x.RazonSocial }).ToList();
            var result = new { Lotes = lotes, Proveedores = proveedores };
            return Json(result);
        }
    }
}