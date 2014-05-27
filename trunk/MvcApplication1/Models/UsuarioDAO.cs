﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace MvcApplication1.Models
{
    public class UsuarioDAO
    {
        private List<Usuario> ListaUsuarios=new List<Usuario>(); 

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

    }
}