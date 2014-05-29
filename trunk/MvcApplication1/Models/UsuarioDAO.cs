using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace MvcApplication1.Models
{
    public class UsuarioDAO
    {
        private List<Usuario> ListaUsuarios=new List<Usuario>();
        private String usuario;
        private int usuarioId;
        private String password;

        


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
                uUsuario.Nombre = (string) reader["USUARIO"];
                uUsuario.Usuario1 = (int) reader["USUARIO_ID"];
                ListaUsuarios.Add(uUsuario);
            }
            reader.Close();
            data.sqlConnection.Close();
            return ListaUsuarios;

        }

        public Boolean ValidarUsuario(String usuario, String password)
        {
            Boolean usuarioValido;
            Datos data = new Datos();
            data.conectar();
            SqlCommand command = data.sqlConnection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select usuario_id from USUARIOS where usuario='"+ this.g  +
                "' and password='"+password+"'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                usuarioValido= true;
           }
            else
            {
                usuarioValido= false;
            }

            reader.Close();
            data.sqlConnection.Close();
            return usuarioValido;

        }

    }
}