using System;
using System.ComponentModel;

namespace MvcApplication1.Models
{
    public class Usuario
    {
        public String usuario { get; set; }
        public int usuarioId { get; set; }
        private String nombre;
        private String apellido;
        public String password { get; set; }
        public Boolean autorizado { get; set; }


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

        public Boolean ValidarUsuario()
        {
            Boolean usuarioValido;
            UsuarioDAO uDAO = new UsuarioDAO();
            uDAO.usuario = this.usuario;
            uDAO.password = this.password;

            if (uDAO.ValidarUsuario())
            {
                usuarioValido = true;
            }
            else
            {
                usuarioValido = false;
            }

            return usuarioValido;
        }

        public Usuario GetUsuarioId(String uDto)
        {
            UsuarioDAO uDAO=new UsuarioDAO();
            Usuario uDTO=new Usuario();
            uDTO=uDAO.GetUsuarioIdDAO(uDto);
            return uDTO;

        }
        
    }
}
