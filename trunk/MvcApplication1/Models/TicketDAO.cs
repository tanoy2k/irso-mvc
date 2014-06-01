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
            command.Parameters.AddWithValue("@TICKET_DESCRIPCION", t.TicketDescripcion);
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

       
        public Ticket getTciketporId(int id)
        {
            Ticket tktXid = new Ticket();
            List<TicketDetalle> tktDet=new List<TicketDetalle>();
            Datos data = new Datos();
            data.conectar();
            SqlCommand command = new SqlCommand();
            command.Connection = data.sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GET_TICKET";
            command.Parameters.AddWithValue("@TICKET_ID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tktXid.TicketId = (int) reader["TICKET_ID"];
                tktXid.Estado = (int) reader["ESTADO_ID"];
                tktXid.EstadoDescripcion = (string) reader["ESTADO_DESCRIPCION"];
                tktXid.Prioridad = (int) reader["PRIORIDAD_ID"];
                tktXid.PrioridadDescripcion = (string) reader["PRIORIDAD_DESCRIPCION"];
                tktXid.Usuario = (int) reader["USUARIO_CREO"];
                tktXid.UsuarioDescripcion=(string)reader["USUARIO_CREO_DESCRIPCION"];
                tktXid.UsuarioAsignado=(int)reader["USUARIO_ASIGNADO"];
                tktXid.UsuarioAsignadoDescripcion=(string)reader["USUARIO_ASIGNADO_DESCRIPCION"];
                
            }
            reader.Close();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from TICKETS_DETALLE WHERE TICKET_ID="+id;
            var reader2 = command.ExecuteReader();
            while (reader2.Read())
            {
             TicketDetalle tDetalle= new TicketDetalle();
                tDetalle.UsuarioDetalle = (int) reader2["USUARIO_DETALLE"];
                tDetalle.Observaciones = (string) reader2["OBSERVACIONES"];
             tktDet.Add(tDetalle);   
            }
            tktXid.TicketDetalle = tktDet;
            return tktXid;
        }


    }
}