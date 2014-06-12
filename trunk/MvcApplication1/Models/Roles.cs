using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Roles
    {
        private Int32 rol_id;
        private String rol_descripcion;

        public int Rol_id
        {
            get { return this.rol_id; }
            set { this.rol_id = value; }
        }

        public String Rol_descripcion
        {
            get { return this.rol_descripcion; }
            set { this.rol_descripcion = value; }
        }
    }
}