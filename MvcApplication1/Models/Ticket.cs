using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Ticket
    {
        private Int32 ticket;
        private Int32 usuario;
        private Int32 estado;
        private Int32 prioridad;
        private String hash;

        public int Ticket1
        {
            get { return ticket; }
            set { ticket = value; }
        }

        public int Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

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
    }
}