using System;
using System.ComponentModel;

namespace MvcApplication1.Models
{
    public class Usuario
    {
        private Int32 usuario;
        private String nombre;
        private String apellido;
        private String password;

        public int Usuario1
        {
            get { return usuario; }
            set { usuario = value; }
        }

        [DisplayName("Nombre")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
    }
}
