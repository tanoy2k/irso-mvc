using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class TicketDAO
    {
        public void SaveTicketDAO(Ticket tickdao,TicketDetalle tickdaodet)
        {
            Ticket t=new Ticket();
            TicketDetalle td=new TicketDetalle();
            t = tickdao;
            td = tickdaodet;
            Datos data = new Datos();
            data.conectar();
            SqlCommand command = data.sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO TICKETS (USUARIO_CREO,USUARIO_ASIGNADO,ESTADO_ID,PRIORIDAD_ID) VALUES ('"+
                                    t.Usuario + "','" + t.Usuario + "','"+
                                  t.Estado+"','" + t.Prioridad+"')";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            data.sqlConnection.Close();

        }
    }
}