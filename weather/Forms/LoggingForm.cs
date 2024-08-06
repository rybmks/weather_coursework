using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using weather.Session;

namespace weather
{
    public partial class LoggingForm : Form
    {
        public LoggingForm()
        {
            InitializeComponent();

            this.AcceptButton = EnterButton;

            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Width, 47);
       
            this.LogginField.Text = "Enter login";
            this.LogginField.ForeColor = Color.Gray;

            PasswordField.Text = "Enter password";
            PasswordField.ForeColor = Color.Gray;
            PasswordField.UseSystemPasswordChar = false;
            
            this.ActiveControl = null;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainFormReturner.MainLink.Show();
            this.Hide();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            String login = LogginField.Text;
            String password = PasswordField.Text;

            if (IsValid.IsValidData(login, password))
            {
                MessageBox.Show("Вхід виконано успішно!");
                AdminPannel adminPannel = new AdminPannel();
                adminPannel.Show();
                this.Hide();
                SessionManager.IsAuthenticated = true;
                SessionManager.LogAs = login;
            }
            else
                MessageBox.Show("Неправильний логін або пароль");
        }

        private void LoggingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFormReturner.MainLink.Show();
            this.Hide();
        }

        private void EnterButton_MouseEnter(object sender, EventArgs e)
        {
            EnterButton.ForeColor = Color.Blue;
            EnterButton.Cursor = Cursors.Hand;
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.Blue;
            BackButton.Cursor = Cursors.Hand;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.White;
            BackButton.Cursor = Cursors.Default;
        }

        private void EnterButton_MouseLeave(object sender, EventArgs e)
        {
            EnterButton.ForeColor = Color.White;
            EnterButton.Cursor = Cursors.Default;
        }

        private void LogginField_Enter(object sender, EventArgs e)
        {
            if (LogginField.Text == "Enter login") 
            { 
                LogginField.Text = "";
                LogginField.ForeColor = Color.Black;
            }
        }

        private void LogginField_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LogginField.Text))
            {
                LogginField.Text = "Enter login";
                LogginField.ForeColor = Color.Gray;
            }
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (PasswordField.Text == "Enter password")
            {
                PasswordField.Text = "";
                PasswordField.ForeColor = Color.Black;
                PasswordField.UseSystemPasswordChar = true;
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordField.Text))
            {
                PasswordField.Text = "Enter password";
                PasswordField.ForeColor = Color.Gray;
                PasswordField.UseSystemPasswordChar = false;
            }
        }
    }
}
