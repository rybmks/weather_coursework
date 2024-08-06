using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather.Session
{
    public static class IsValid
    {
        public static bool IsValidData(string login, string password)
        {
            DB db = new DB();
            db.OpenConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand(
                "SELECT * FROM LoggingTable WHERE Login COLLATE SQL_Latin1_General_CP1_CS_AS = @uL AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = @uP"
                , db.GetConnection());

            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.CloseConnection();

            return (table.Rows.Count > 0);
        }
    }
}
