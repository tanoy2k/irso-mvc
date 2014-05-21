using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class TicketDetalle
    {

        private int ticketid;
        private string detalle;
        private int usuario_detalle;

        public int Ticketid
        {
            get { return ticketid; }
            set { ticketid = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public int UsuarioDetalle
        {
            get { return usuario_detalle; }
            set { usuario_detalle = value; }
        }
    }
}