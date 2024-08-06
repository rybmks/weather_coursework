using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weather.Forms
{
    public partial class WeatherForm : Form
    {
        private List<Weather> _weathers;
        public WeatherForm(List<Weather> weathers)
        {
            InitializeComponent();

            _weathers = weathers;
            CityLabel.Text = _weathers[0].City;
            TempLabel.Text = "Оберіть дату.";
            HumidLabel.Text = "Оберіть дату.";
            StatusLabel.Text = "Оберіть дату.";
            DescripLabel.Text = "Оберіть дату.";

            PopulateComboBox();
        }
        private void DatesList_SelectedValueChanged(object sender, EventArgs e)
        {
            Weather selectedWeather = _weathers.Find(w => w.Date == DatesList.SelectedItem.ToString());

            TempLabel.Text = selectedWeather.Temperature.ToString() + "°C";
            HumidLabel.Text = selectedWeather.Humidity.ToString() + "%";
            StatusLabel.Text = selectedWeather.Status.ToString();
           
            if (!String.IsNullOrWhiteSpace(selectedWeather.Description))
            {
                DescripLabel.Text = selectedWeather.Description;
            }
            else
                DescripLabel.Text = "Немає спеціального опису";
        }

       
        private void PopulateComboBox()
        {

            var uniqueDates = _weathers.Select(w => w.Date).Distinct().ToList();

            foreach (var uniqueDate in uniqueDates)
            {
                DatesList.Items.Add(uniqueDate);
            }
        }
        private void BackMenuButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void WeatherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFormReturner.MainLink.Show();
            this.Hide();
        }

    }
}
