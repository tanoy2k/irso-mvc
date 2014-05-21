using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Estados
    {
        private Int32 estado_id;
        private String estado_descripcion;

        public int EstadoId
        {
            get { return estado_id; }
            set { estado_id = value; }
        }

        public string EstadoDescripcion
        {
            get { return estado_descripcion; }
            set { estado_descripcion = value; }
        }
    }
}