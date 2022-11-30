using MVCProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProyecto.Dato
{
    public class RopaAdmin
    {
        public IEnumerable<ropa> Consultar()
        {
            using(RopaEntities cont = new RopaEntities()) { 
                return cont.ropa.AsNoTracking().ToList();
            }
        }
        //Guardar ropa
        public void Guardar(ropa modelo)
        {
            using (RopaEntities cont = new RopaEntities())
            {
                cont.ropa.Add(modelo);
                cont.SaveChanges();
            }
        }
        //detalle
        public ropa Consultar(int id)
        {
            using (RopaEntities cont = new RopaEntities())
            {
                return cont.ropa.FirstOrDefault(d=> d.Id== id);
            }

        }

        public void Modificar(ropa modelo)
        {
            using(RopaEntities cont= new RopaEntities())
            {
                cont.Entry(modelo).State=System.Data.Entity.EntityState.Modified;
                cont.SaveChanges();
            }
        }
        public void Eliminar (ropa modelo)
        {
            using (RopaEntities cont = new RopaEntities())
            {
                cont.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                cont.SaveChanges();
            }
        }

        ///// PARTE DEL CALZADO
        public IEnumerable<calzado> ConsultarC()
        {
            using (CalzadoEntities cont = new CalzadoEntities())
            {
                return cont.calzado.AsNoTracking().ToList();
            }
        }
        public void Guardar(calzado modelo)
        {
            using (CalzadoEntities  cont = new CalzadoEntities())
            {
                cont.calzado.Add(modelo);
                cont.SaveChanges();
            }
        }
        public calzado ConsultarC(int id)
        {
            using (CalzadoEntities cont = new CalzadoEntities())
            {
                return cont.calzado.FirstOrDefault(d => d.Id == id);
            }

        }

        public void Modificar(calzado modelo)
        {
            using (CalzadoEntities cont = new CalzadoEntities())
            {
                cont.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                cont.SaveChanges();
            }
        }
        public void Eliminar(calzado modelo)
        {
            using (CalzadoEntities cont = new CalzadoEntities())
            {
                cont.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                cont.SaveChanges();
            }
        }

    }
}