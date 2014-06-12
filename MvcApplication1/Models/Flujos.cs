using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Flujos
    {
        private int rol_id;
        private int estado_inicial_id;
        private int estado_final_id;
        private int flujo_habilitado;

        public int Rol_id
        {
            get { return this.rol_id; }
            set { this.rol_id = value; }
        }

        public int Estado_inicial_id
        {
            get { return this.estado_inicial_id; }
            set { this.estado_inicial_id = value; }
        }

        public int Estado_final_id
        {
            get { return this.estado_final_id; }
            set { this.estado_final_id = value; }
        }

        public int Flujo_habilitado
        {
            get { return this.flujo_habilitado; }
            set { this.flujo_habilitado = value; }
        }
    }
}
