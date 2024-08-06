using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using weather.Forms;

namespace weather
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainFormReturner.MainLink = this;
            this.AcceptButton = FindWeather;
        }

        private void LogAsAdmin_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsAuthenticated) 
            {
                LoggingForm loggingForm = new LoggingForm();
                loggingForm.Show();
            }
            else
            {
                AdminPannel adminPannel = new AdminPannel();
                adminPannel.Show();
            }
            this.Hide();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (SessionManager.IsAuthenticated)
                SessionLabel.Text = "Ви увійшли як " + SessionManager.LogAs;

            else
                SessionLabel.Text = "";
        }
        private void FindWeather_Click(object sender, EventArgs e)
        {
            String location = Location.Text;
            if (!String.IsNullOrEmpty(location))
            {
                List<Weather> weathers = new DBCityWeatherGetter(location).Weathers();

                if (weathers.Count > 0)
                {
                    MessageBox.Show("Знайдено записів: " + weathers.Count);
                    WeatherForm weatherForm = new WeatherForm(weathers);
                    this.Hide();
                    weatherForm.Show();
                }
                else
                    MessageBox.Show("На жаль, за вказаним містом дані відсутні.");
            }
            else
                MessageBox.Show("Введіть назву міста!");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (SessionManager.IsAuthenticated)
            {
                SessionLabel.Show();
                LogOut.Show();
                SessionLabel.Text = "Ви увійшли як " + SessionManager.LogAs;
                LogOut.Text = "Вийти";
            }
            else 
            {
                SessionLabel.Text = "";
                LogOut.Text = "";
                SessionLabel.Hide();
                LogOut.Hide();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show(
                "Ви впевнені, що хочете вийти з облікового запису?",
                "Вихід",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if(result == DialogResult.Yes)
            {
                SessionManager.IsAuthenticated = false;
                MessageBox.Show("Ви вийшли з акаунту " + SessionManager.LogAs);
                SessionManager.LogAs = null;

                SessionLabel.Text = "";
                LogOut.Text = "";
                SessionLabel.Hide();
                LogOut.Hide();
            }
        }

        private void LogOut_MouseEnter(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.DarkBlue;
            LogOut.Cursor = Cursors.Hand;
        }

        private void LogOut_MouseLeave(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.MediumBlue;
            LogOut.Cursor = Cursors.Default;
        }

        private void FindWeather_MouseEnter(object sender, EventArgs e)
        {
            FindWeather.Cursor = Cursors.Hand;
            LogAsAdmin.Cursor = Cursors.Hand;
        }

        private void FindWeather_MouseLeave(object sender, EventArgs e)
        {
            FindWeather.Cursor = Cursors.Default;
            LogAsAdmin.Cursor = Cursors.Default;
        }
    }
}
