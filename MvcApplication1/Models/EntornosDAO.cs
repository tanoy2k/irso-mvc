using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class EntornosDAO
    {
        private List <Estados> estadosList = new List<Estados>();
        private List<Prioridades> prioridadesList = new List<Prioridades>();


        public List<Estados> GetEstados()
        {
            Datos data = new Datos();
            data.conectar();
            SqlCommand command = data.sqlConnection.CreateCommand();
            command.CommandText = "Select * from ESTADOS";
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Estados uEstado = new Estados();
                uEstado.EstadoId = (int) reader["ESTADO_ID"];
                uEstado.EstadoDescripcion = reader["ESTADO_DESCRIPCION"].ToString();
                estadosList.Add(uEstado);
            }
            reader.Close();
            data.sqlConnection.Close();
            return estadosList;
        }

        public List<Prioridades> GetPrioridades()
        {
            Datos data = new Datos();
            data.conectar();
            SqlCommand command = data.sqlConnection.CreateCommand();
            command.CommandText = "Select * from PRIORIDADES";
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Prioridades uPrioridades = new Prioridades();
                uPrioridades.PrioridadId = (int)reader["PRIORIDAD_ID"];
               uPrioridades.PrioridadDescripcion = reader["PRIORIDAD_DESCRIPCION"].ToString();
               prioridadesList.Add(uPrioridades);
            }
            reader.Close();
            data.sqlConnection.Close();
            return prioridadesList;
        } 
    }
}