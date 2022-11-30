using MVCProyecto.Dato;
using MVCProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProyecto.Controllers
{
    public class RopaController : Controller
    {
        RopaAdmin admin = new RopaAdmin();  
        // GET: Ropa
        public ActionResult Index()
        {
            IEnumerable<ropa> lista = admin.Consultar();
            ViewBag.mensaje = "";
            return View(lista);
        }
        //guardar
        public ActionResult Guardar() {
            ViewBag.mensaje = "";
            return View();
        }
        public ActionResult Nuevo(ropa modelo) { 
            admin.Guardar(modelo);
            ViewBag.mensaje = "Articulo Guardado con Éxito";
            return View("Guardar",modelo);
        }

        //detalle
        public ActionResult Detalle(int id = 0)
        {
            ropa modelo = admin.Consultar(id);
            ViewBag.mensaje = "";
            return View(modelo);
        }

        public ActionResult Modificar (int id = 0)
        {
            ropa modelo = admin.Consultar(id);
            return View(modelo);
        }
        public ActionResult Actualizar(ropa modelo)
        {
            admin.Modificar(modelo);
            ViewBag.mensaje = "Se Modifico con Éxito";
            return View("Modificar",modelo);
        }

        public ActionResult Eliminar (int id=0)
        {
            ropa modelo = new ropa()
            {
                Id= id

            };
            admin.Eliminar(modelo);
            IEnumerable<ropa> lista = admin.Consultar();
            ViewBag.mensaje = "Articulo Eliminado";
            return View("Index", lista);
        }



    }
}
