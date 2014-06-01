using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Microsoft.SqlServer.Server;

namespace MvcApplication1.Models
{
    public class UsuarioDAO
    {
        private List<Usuario> ListaUsuarios=new List<Usuario>();
        public String usuario { get; set; }
        public int usuarioId { get; set; }
        public String password { get; set; }
        

       
        


        public List<Usuario> GetAlumnos()
        {
            Datos data = new Datos();
            data.conectar();
            SqlCommand command = data.sqlConnection.CreateCommand();
            command.CommandText = "Select * from USUARIOS";
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Usuario uUsuario = new Usuario();
                uUsuario.usuario = (String)reader["USUARIO"];
                uUsuario.usuarioId = (int) reader["USUARIO_ID"];
                ListaUsuarios.Add(uUsuario);
            }
            reader.Close();
            data.sqlConnection.Close();
            return ListaUsuarios;

        }

        public Boolean ValidarUsuario()
        {
            Boolean usuarioValido;
            Datos data = new Datos();
            data.conectar();
            SqlCommand command = data.sqlConnection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from USUARIOS where usuario='"+ this.usuario +
                "' and password='"+this.password+"'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                usuarioValido= true;
           }
            else
            {
                usuarioValido= false;
            }

            while (reader.Read())
            {
                this.usuarioId = (int)reader["USUARIO_ID"];
            }


            reader.Close();
            data.sqlConnection.Close();
            return usuarioValido;

        }

        public Usuario GetUsuarioIdDAO(String uDto)
    {
        Datos data = new Datos();
        data.conectar();
        SqlCommand command = data.sqlConnection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "Select * from USUARIOS where usuario='" + uDto +"'";
        SqlDataReader reader = command.ExecuteReader();
            Usuario uDAO=new Usuario();
            while (reader.Read())
            {
                uDAO.usuarioId = (int)reader["USUARIO_ID"];
            }
            reader.Close();
            data.sqlConnection.Close();
            return uDAO;


    }

    }
}