using Airlines.FormApplication.Controller;
using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines.FormApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async Task<bool> CheckAdmin(int id)
        {
            UserDto user = await Program.Instance.UserController.UserById(id);
            if (user.Role.Equals("User"))
                return false;
            else
                return true;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(usernameTxb.Text) ||
                String.IsNullOrEmpty(passwordTxb.Text))
            {
                MessageBox.Show("Username or Password box is blank");
            }
            else
            {
                int re = await Program.Instance.UserController.Authenticate(
                    usernameTxb.Text,
                    Utilities.ToHashString(passwordTxb.Text));
                switch (re)
                {
                    case -1:
                        MessageBox.Show("Wrong username or password");
                        break;
                    case 0:
                        MessageBox.Show("Account disable");
                        break;
                    case 1:
                        int _id = await Program.Instance.UserController.UserId(usernameTxb.Text);
                        string _date = DateTime.UtcNow.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                        string _time = DateTime.UtcNow.TimeOfDay.ToString(@"hh\:mm\:ss");
                        string _confidence = await Program.Instance.UserActivityController.LoginLogs(_id, _date, _time);
                        NoLogOutForm noLogOutForm = new NoLogOutForm(_id, _confidence);
                        noLogOutForm.ShowDialog();
                        bool x = await CheckAdmin(_id);
                        if (x)
                            AdminFormLoad(_id, _confidence);
                        else
                            UserFormLoad(_id, _confidence);
                        break;
                    case 2:
                        int id = await Program.Instance.UserController.UserId(usernameTxb.Text);
                        string date = DateTime.UtcNow.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                        string time = DateTime.UtcNow.TimeOfDay.ToString(@"hh\:mm\:ss");
                        string confidence = await Program.Instance.UserActivityController.LoginLogs(id,date,time);
                        bool check = await CheckAdmin(id);
                        if (check)
                            AdminFormLoad(id, confidence);
                        else
                            UserFormLoad(id, confidence);
                        break;
                }
            }
        }

        private void AdminFormLoad(int uid, string confidence)
        {
            MainFormAdmin _mainForm = new MainFormAdmin(uid, confidence);
            _mainForm.FormClosed += MainForm_FormClosed;
            _mainForm.Show();
            this.Visible = false;
        }

        private void UserFormLoad(int uid, string confidence)
        {
            MainFormUser mainForm = new MainFormUser(uid,confidence);
            mainForm.FormClosed += MainForm_FormClosed1;
            mainForm.Show();
            this.Visible = false;
        }

        private void MainForm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
