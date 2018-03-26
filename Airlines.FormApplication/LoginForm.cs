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
        private int _countfail = 0;
        private int _secRemaining = 10;

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

        void TaskRunning()
        {
            statusLbl.Visible = true;
            loginBtn.Enabled = false;
        }

        void TaskEnd()
        {
            statusLbl.Text = "Please wait...";
            statusLbl.Visible = false;
            loginBtn.Enabled = true;
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
                TaskRunning();
                int re = await Program.Instance.UserController.Authenticate(
                    usernameTxb.Text,
                    Utilities.ToHashString(passwordTxb.Text));
                switch (re)
                {
                    case -1:
                        await LoginFail();
                        break;
                    case 0:
                        MessageBox.Show("Account disable");
                        break;
                    case 1:
                        await EnterMainFormUserNoLogOut();
                        break;
                    case 2:
                        await EnterMainForm();
                        break;
                }
                TaskEnd();
            }
        }

        private async Task LoginFail()
        {
            _countfail++;
            if (_countfail == 3)
            {
                loginfailTimer.Start();
                TaskRunning();
                await Task.Delay(11000);
                TaskEnd();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private async Task EnterMainForm()
        {
            int idcase2 = await Program.Instance.UserController.UserId(usernameTxb.Text);
            string datecase2 = DateTime.UtcNow.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            string timecase2 = DateTime.UtcNow.TimeOfDay.ToString(@"hh\:mm\:ss");
            string confidencecase2 = await Program.Instance.UserActivityController.LoginLogs(idcase2, datecase2, timecase2);
            bool check = await CheckAdmin(idcase2);
            if (check)
                AdminFormLoad(idcase2, confidencecase2);
            else
                UserFormLoad(idcase2, confidencecase2);
        }

        private async Task EnterMainFormUserNoLogOut()
        {
            int id = await Program.Instance.UserController.UserId(usernameTxb.Text);
            string date = DateTime.UtcNow.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            string time = DateTime.UtcNow.TimeOfDay.ToString(@"hh\:mm\:ss");
            string confidence = await Program.Instance.UserActivityController.LoginLogs(id, date, time);
            NoLogOutForm noLogOutForm = new NoLogOutForm(id, confidence);
            noLogOutForm.ShowDialog();
            bool x = await CheckAdmin(id);
            if (x)
                AdminFormLoad(id, confidence);
            else
                UserFormLoad(id, confidence);
        }

        private void AdminFormLoad(int uid, string confidence)
        {
            MainFormAdmin mainForm = new MainFormAdmin(uid, confidence);
            mainForm.FormClosed += MainForm_FormClosed;
            mainForm.Show();
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

        private void loginfailTimer_Tick(object sender, EventArgs e)
        {
            _secRemaining--;
            statusLbl.Text = $"You've logged in wrong 3 times " +
                $"Please wait {_secRemaining} seconds";
            if (_secRemaining == 0)
            {
                loginfailTimer.Stop();
                _secRemaining = 10;
                _countfail = 0;
            }
        }
    }
}
