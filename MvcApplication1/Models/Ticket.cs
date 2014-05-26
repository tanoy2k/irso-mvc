﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class Ticket
    {
        private Int32 ticket;
        private Int32 usuario;
        private Int32 estado;
        private Int32 prioridad;
        private Int32 usuario_asignado;
        private List <TicketDetalle> ticketDetalle;

        public List<TicketDetalle> TicketDetalle
        {
            get { return ticketDetalle; }
            set { ticketDetalle = value; }
        }

        public int UsuarioAsignado
        {
            get { return usuario_asignado; }
            set { usuario_asignado = value; }
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

        

        
    }
}