using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class Ticket
    {
        private Int32 ticket;
        private String ticketDescripcion;

      

        private Int32 usuario;
        private String usuarioDescripcion;
        private Int32 estado;
        private String estadoDescripcion;
        private Int32 prioridad;
        private String prioridadDescripcion;
        private Int32 usuarioAsignado;
        private String usuarioAsignadoDescripcion;
        private List<TicketDetalle> ticketDetalle;

   


        public string UsuarioDescripcion
        {
            get { return usuarioDescripcion; }
            set { usuarioDescripcion = value; }
        }

        public string EstadoDescripcion
        {
            get { return estadoDescripcion; }
            set { estadoDescripcion = value; }
        }

        public string PrioridadDescripcion
        {
            get { return prioridadDescripcion; }
            set { prioridadDescripcion = value; }
        }

        public string UsuarioAsignadoDescripcion
        {
            get { return usuarioAsignadoDescripcion; }
            set { usuarioAsignadoDescripcion = value; }
        }

  
        public List<TicketDetalle> TicketDetalle
        {
            get { return ticketDetalle; }
            set { ticketDetalle = value; }
        }

        public int UsuarioAsignado
        {
            get { return usuarioAsignado; }
            set { usuarioAsignado = value; }
        }

        public string TicketDescripcion
        {
            get { return ticketDescripcion; }
            set { ticketDescripcion = value; }
        }

        private String hash;

        [DisplayName("RPRPRPRPRP")]
        public string nombreu { get; set; }

       

        public int TicketId
        {
            get { return ticket; }
            set { ticket = value; }
        }

        public int Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        [DisplayName("Estado")]
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        [Required]
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        public string Hash
        {
            get { return hash; }
            set { hash = value; }
        }

        public void SaveTicket(Ticket tick,TicketDetalle tickdet)
        {
            Ticket t1=new Ticket();
            TicketDetalle t2=new TicketDetalle();
            t1 = tick;
            t2 = tickdet;
            TicketDAO tdao = new TicketDAO();
            tdao.SaveTicketDAO(t1,t2);
        }

        public Ticket ticketDao(int id )
        {
            Ticket tick = new Ticket();
            TicketDAO tDao = new TicketDAO();
            tick = tDao.getTciketporId(id);
            return tick;
        }

        

        
    }
}