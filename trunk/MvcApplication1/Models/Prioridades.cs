using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Prioridades
    {
        private Int32 prioridad_id;
        private String prioridad_descripcion;

        public int PrioridadId
        {
            get { return prioridad_id; }
            set { prioridad_id = value; }
        }

        public string PrioridadDescripcion
        {
            get { return prioridad_descripcion; }
            set { prioridad_descripcion = value; }
        }
    }
}