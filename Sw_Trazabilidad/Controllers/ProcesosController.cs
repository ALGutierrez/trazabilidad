using Sw_Trazabilidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sw_Trazabilidad.Controllers
{
    public class ProcesosController : Controller
    {
        private readonly Contexto db = new Contexto();
        // GET: Procesos
        public ActionResult NuevoProceso()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevoProceso1()
        {
            return View();
        }
    }
}