using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class TicketDetalle
    {

        private int ticketid;
        private string observaciones;
        private int usuario_detalle;

        public int Ticketid
        {
            get { return ticketid; }
            set { ticketid = value; }
        }

        [Required]
        public string Observaciones { get; set; }

        public int UsuarioDetalle
        {
            get { return usuario_detalle; }
            set { usuario_detalle = value; }
        }
    }
}