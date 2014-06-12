using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MvcApplication1.Models
{
    public class FlujosDAO
    {

        private List<int> flujoPermitido = new List<int>();

        public List<int> getFlujoPermitido(int rol_id, int estado_inicial_id)
        {
            Datos data = new Datos(); 
            data.conectar();
            SqlCommand command = data.sqlConnection.CreateCommand();
            command.CommandText = "Select * from FLOW where rol_id = " + rol_id + " and estado_inicial = " + estado_inicial_id ;
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                flujoPermitido.Add((int)reader["ESTADO_FINAL_ID"]);
            }
            reader.Close();
            data.sqlConnection.Close();
            return flujoPermitido;
        }

    }
}