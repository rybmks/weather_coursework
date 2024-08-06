using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace weather
{
    public class DBCityWeatherGetter
    {
        private string _city;
        public DBCityWeatherGetter(string city)
        {
            _city = city;
        }
        public List<Weather> Weathers() 
        {

            DB db = new DB();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Weather WHERE City = @ct COLLATE Ukrainian_CI_AS", db.GetConnection());
            command.Parameters.AddWithValue("@ct", SqlDbType.VarChar).Value = _city;
           
            adapter.SelectCommand = command;
            adapter.Fill(table);
           
            List<Weather> weathers = new List<Weather>();
            if (table.Rows.Count > 0) 
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    weathers.Add(new Weather
                    {
                        City = _city,
                        Date = table.Rows[i]["Date"].ToString(),
                        Temperature = Convert.ToSingle(table.Rows[i]["Temperature"]),
                        Humidity = Convert.ToSingle(table.Rows[i]["Humidity"]),
                        Status = table.Rows[i]["Status"].ToString(),
                        Description = table.Rows[i]["Description"].ToString()
                    });
                }
            }

            return weathers;
        }
    }
}
