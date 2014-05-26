using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MvcApplication1.Models
{
    public class TicketDAO


    {
        private List<Ticket> ListaTickets = new List<Ticket>(); 

        public void SaveTicketDAO(Ticket tickdao,TicketDetalle tickdaodet)
        {
            Ticket t=new Ticket();
            TicketDetalle td=new TicketDetalle();
            t = tickdao;
            td = tickdaodet;
            Datos data = new Datos();
            data.conectar();
            SqlCommand command = new SqlCommand();
            command.Connection = data.sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CREATE_TICKETS";
            command.Parameters.AddWithValue("@ESTADO_ID",t.Estado);
            command.Parameters.AddWithValue("@PRIORIDAD_ID",t.Prioridad);
            command.Parameters.AddWithValue("@USUARIO_CREO",t.Usuario);
            command.Parameters.AddWithValue("@USUARIO_ASIGNADO",t.UsuarioAsignado);
            command.Parameters.AddWithValue("@USUARIO_DETALLE", td.UsuarioDetalle);
            command.Parameters.AddWithValue("@OBSERVACIONES", td.Observaciones);
            DateTime d=new DateTime();
            d= DateTime.Now;
            command.Parameters.AddWithValue("@FECHA_CREACION", d);
            command.ExecuteNonQuery();
            data.sqlConnection.Close();
            }

        public List<Ticket> GetAllTicketsDAO()
        {
            Datos data = new Datos();
            data.conectar();
            SqlCommand command = data.sqlConnection.CreateCommand();
            command.CommandText = "Select * from TICKETS";
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ticket uTicket = new Ticket();
                uTicket.Usuario = (int) reader["USUARIO_CREO"];
                uTicket.Estado = (int) reader["ESTADO_ID"];
                uTicket.TicketId = (int) reader["TICKET_ID"];
                ListaTickets.Add(uTicket);
            }
            reader.Close();
            data.sqlConnection.Close();
            return ListaTickets;
        }


    }
}