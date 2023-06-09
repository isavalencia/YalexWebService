using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AyalexJson.Models;
namespace AyalexJson.Controllers
{
    public class JClienteController : Controller
    {
        
        // GET: JCliente
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ObtenerCli()
        {
            //List<cliente> lista;
            using(yalexrentacarEntities db = new yalexrentacarEntities())
            {
               var lista = (from d in db.clientes 
                       select  new { d.id_cliente, d.nombres, d.apellidos, d.direccion, d.telefono, d.correo, d.licencia, d.dui, d.estado, d.contrasena, d.rol}).ToList();

                return Json(lista, JsonRequestBehavior.AllowGet);
            }

           
        }
    }
}