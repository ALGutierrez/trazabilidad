using Sw_Trazabilidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sw_Trazabilidad.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly Contexto db = new Contexto();
        // GET: Empresas
        public ActionResult NuevaEmpresa()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevaEmpresa(string RazonSocial, string CUIT, string Direccion)
        {
            Empresa_Proveedor empresa = new Empresa_Proveedor()
            {
                RazonSocial = RazonSocial,
                CUIT = CUIT,
                Direccion = Direccion
            };

            db.EmpresasProveedores.Add(empresa);
            db.SaveChanges();

            return View();
        }
    }
}