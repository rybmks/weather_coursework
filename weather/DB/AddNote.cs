using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace weather
{
    public static class AddNote
    {
        public static bool AddToDb(string city, string date, float temp,
                                   float humid, string status, string descreip)
        {
            DB db = new DB();
            db.OpenConnection();
           
            if (IsInBd(city, date))
            {
                db.CloseConnection();
                return false;
            }
           
            SqlCommand insert = new SqlCommand("INSERT INTO [Weather] (City, Date, Temperature, Humidity, Status, Description) VALUES (@City, @Date, @Temperature, @Humidity, @Status, @Description)", db.GetConnection());

            insert.Parameters.AddWithValue("@City", city);
            insert.Parameters.AddWithValue("@Date", date);
            insert.Parameters.AddWithValue("@Temperature", temp);
            insert.Parameters.AddWithValue("@Humidity", humid);
            insert.Parameters.AddWithValue("@Status", status);
            insert.Parameters.AddWithValue("@Description", descreip);


            bool isAdd = insert.ExecuteNonQuery() > 0;
            db.CloseConnection();
            return isAdd;
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