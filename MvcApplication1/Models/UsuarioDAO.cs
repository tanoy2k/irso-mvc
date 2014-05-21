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

        public List<Usuario> GetAlumnos()
        {
          Datos data = new Datos();
            data.conectar();
            SqlCommand command = data.sqlConnection.CreateCommand();
            command.CommandText = "Select * from ALUMNOS";
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string output = reader["NOMBRE"].ToString();
                string output2 = reader["DNI"].ToString();
                Console.WriteLine(output);
                Usuario uList = new Usuario();
                uList.Nombre=output;
                uList.Apellido = output2;
                ListaUsuarios.Add(uList);
            }
            reader.Close();
            data.sqlConnection.Close();
            return ListaUsuarios;

        }

    }
}