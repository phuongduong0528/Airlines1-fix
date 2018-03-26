using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines.FormApplication
{
    public partial class MainFormUser : Form
    {
        private int Uid;
        private string confidence;
        private UserDto user;
        private List<UserActivityDto> userActivityDtos;
        
        public MainFormUser(int uid, string _confidence)
        {
            InitializeComponent();
            Uid = uid;
            confidence = _confidence;
        }

        public MainFormUser()
        {
            InitializeComponent();
        }

        private async void MainFormUser_Load(object sender, EventArgs e)
        {
            user = await Program.Instance.UserController.UserById(Uid);
            userActivityDtos = await Program.Instance.UserActivityController.
                UserActivity(Uid, confidence);
            string totaltime = await Program.Instance.UserActivityController.TotalTimeOnSystem(Uid, confidence);

            useractivityDgv.DataSource = userActivityDtos;

            statusLbl.Text = $"Welcome {user.FirstName}, Total time: {totaltime}";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Program.Instance.UserActivityController.LogoutLogs(
                Uid,
                DateTime.UtcNow.TimeOfDay.ToString(@"hh\:mm\:ss"),
                confidence);
            this.Close();
        }
    }
}
