using MVCProyecto.Dato;
using MVCProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProyecto.Controllers
{
    public class CalzadoController : Controller
    {
        RopaAdmin admin= new RopaAdmin();
        // GET: Calzado
        public ActionResult Index()
        {
            IEnumerable<calzado> lista = admin.ConsultarC();
            ViewBag.mensaje = "";
            return View(lista);
        }

        //guardar
        public ActionResult Guardar()
        {
            ViewBag.mensaje = "";
            return View();
        }

        public ActionResult Nuevo(calzado modelo)
        {
            admin.Guardar(modelo);
            ViewBag.mensaje = "Articulo Guardado con Éxito";
            return View("Guardar",modelo);

        }
        public ActionResult Detalle(int id = 0)
        {
            calzado modelo = admin.ConsultarC(id);
            ViewBag.mensaje = "";
            return View(modelo);
        }

        public ActionResult Modificar(int id = 0)
        {
            calzado modelo = admin.ConsultarC(id);
            return View(modelo);
        }
        public ActionResult Actualizar(calzado modelo)
        {
            admin.Modificar(modelo);
            ViewBag.mensaje = "Se Modifico con Éxito";
            return View("Modificar", modelo);
        }

        public ActionResult Eliminar(int id = 0)
        {
            calzado modelo = new calzado()
            {
                Id = id

            };
            admin.Eliminar(modelo);
            IEnumerable<calzado> lista = admin.ConsultarC();
            ViewBag.mensaje = "Articulo Eliminado";
            return View("Index", lista);
        }

    }
}