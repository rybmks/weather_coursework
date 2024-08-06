using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace weather
{
    public static class DeleteNote
    {
        public static bool DeleteFromDb(string city, string date)
        {
            DB db = new DB();
            db.OpenConnection();

            if (!IsInBd(city, date))
            {
                db.CloseConnection();
                return false;
            }

            SqlCommand delete = new SqlCommand("DELETE FROM [Weather] WHERE City = @City AND Date = @Date", db.GetConnection());

            delete.Parameters.AddWithValue("City", city);
            delete.Parameters.AddWithValue("Date", date);

            if (delete.ExecuteNonQuery() > 0)
            {
                db.CloseConnection();
                return true;
            }
            else 
            {
                db.CloseConnection();
                return false;
            }
            
        }
        private static bool IsInBd(string city, string date)
        {
            DB db = new DB();
            db.OpenConnection();
            SqlCommand check = new SqlCommand("SELECT * FROM [Weather] WHERE City = @City AND Date = @Date", db.GetConnection());
            check.Parameters.AddWithValue("@City", city);
            check.Parameters.AddWithValue("@Date", date);
            SqlDataReader reader = check.ExecuteReader();
            bool isExist = reader.HasRows;
            db.CloseConnection();
            return isExist;
        }
    }
}
