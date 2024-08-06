using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace weather
{
    public class DB 
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["weatherDB"].ConnectionString);
    
        public void OpenConnection()
        {
            if(connection.State == ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
