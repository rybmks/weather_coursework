using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weather
{
    public partial class AdminPannel : Form
    {
        List<Weather> _weathers;
        public AdminPannel()
        {
            InitializeComponent();
        }

        private void BackMenuButton_Click(object sender, EventArgs e)
        {
            MainFormReturner.MainLink.Show();
            this.Hide();
        }

        private void AdminPannel_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFormReturner.MainLink.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            float temp;
            float humid;
            string date = DateField.Text;
            string description;
            string status;
            string city;
            DateTime dateTime;
            if (string.IsNullOrEmpty(CityField.Text) || string.IsNullOrEmpty(DateField.Text) || string.IsNullOrEmpty(TempField.Text) || string.IsNullOrEmpty(HumidField.Text) || string.IsNullOrEmpty(StatusField.Text))
            {
                MessageBox.Show("Заповніть всі обов'язкові поля!");
                return;
            }

            if (CityField.Text.Length > 50)
            { MessageBox.Show("Назва міста повинна бути менше 50 символів!"); return; }
            else { city = CityField.Text; }

            if (DateTime.TryParse(DateField.Text, out dateTime)) 
            { 
            }
            else { MessageBox.Show("Неправильний формат дати!"); return; }
            
            if (float.TryParse(TempField.Text, out temp)) 
            {
                if (!(temp > -70 && temp < 70))
                {
                    MessageBox.Show("Температура повинна бути в межах від -70 до 70 градусів за Цельсієм!");
                    return;
                }
            }
            else { MessageBox.Show("Температура повинна бути числом!"); return; }

            if (float.TryParse(HumidField.Text, out humid))
            {
                if (!(humid > 0 && humid < 100)) 
                {
                    MessageBox.Show("Вологість повинна бути в межах від 0 до 100%!");
                    return;
                }
            }
            else { MessageBox.Show("Вологість повинна бути числом!"); return; }

            if (StatusField.Text.Length > 80)
            { MessageBox.Show("Статус повинен бути менше 80 символів!"); return; }
            else { status = StatusField.Text; }

            if (String.IsNullOrEmpty(DescripField.Text))
            {
                description = "Немає спеціального опису";
            }
            else
            {
                if (DescripField.Text.Length > 130)
                {
                    MessageBox.Show("Опис повинен бути менше 130 символів!");
                    return;
                }
                else
                    description = DescripField.Text;
            }

            if (AddNote.AddToDb(city, date, temp, humid, status, description))
            {
                MessageBox.Show("Запис додано.");
            }
            else { MessageBox.Show("Запис вже є у базі!"); }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(DatesList.Text)) 
            {
                if (DeleteNote.DeleteFromDb(RemovingCity.Text, DatesList.Text))
                {
                    MessageBox.Show("Запис видалено.");
                   _weathers = new DBCityWeatherGetter(RemovingCity.Text).Weathers();
                    PopulateComboBox();
                }
                else { MessageBox.Show("Запис відсутній."); }
            }
            else { MessageBox.Show("Оберіть дату!"); }
        }

        private void SearchCityButton_Click(object sender, EventArgs e)
        {
            _weathers = new DBCityWeatherGetter(RemovingCity.Text).Weathers();
            if (_weathers.Count > 0)
            {
                MessageBox.Show("Знайдено записів: " + _weathers.Count + ". Тепер оберіть дату.");
                PopulateComboBox();
            }
            else 
                MessageBox.Show("Даних за цим містом не знайдено!");
        }
        private void PopulateComboBox()
        {
            DatesList.Items.Clear();
            DatesList.Text = "";

            var uniqueDates = _weathers.Select(w => w.Date).Distinct().ToList();

            foreach (var uniqueDate in uniqueDates)
            {
                DatesList.Items.Add(uniqueDate);
            }
        }
    }
}
