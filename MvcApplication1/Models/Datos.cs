using System.Data.SqlClient;
namespace MvcApplication1.Models
{
    public class Datos
    {
        public SqlConnection sqlConnection = new SqlConnection("Data Source=184.73.184.145;Initial Catalog=TICKETS;User ID=java;Password=Java20142015"); 
        public void conectar()
        {
               
            sqlConnection.Open();

        }
        
      
    }
}