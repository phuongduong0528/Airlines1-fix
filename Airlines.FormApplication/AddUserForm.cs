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
    public partial class AddUserForm : Form
    {
        string confidence;

        public AddUserForm(string _confidence)
        {
            InitializeComponent();
            confidence = _confidence;
        }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailTxb.Text) ||
                String.IsNullOrEmpty(firstnameTxb.Text) ||
                String.IsNullOrEmpty(lastnameTxb.Text) ||
                String.IsNullOrEmpty(passTxb.Text))
            {
                MessageBox.Show("Please fill in the form.");
            }
            else
            {
                UserDto userDto = new UserDto();
                userDto.Id = 0;
                userDto.FirstName = firstnameTxb.Text;
                userDto.LastName = lastnameTxb.Text;
                userDto.Email = emailTxb.Text;
                userDto.BirthDate = birthdateDtp.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                userDto.Active = false;
                userDto.Office = officeCbx.SelectedItem.ToString();
                userDto.Password = Utilities.ToHashString(passTxb.Text);
                userDto.Role = "User";
                bool re = await Program.Instance.UserController.AddUser(userDto, confidence);
            }
        }

        private async void AddUserForm_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            List<string> office = await Program.Instance.UserController.ListOffice();
            foreach(string s in office)
            {
                officeCbx.Items.Add(s);
            }
            officeCbx.SelectedIndex = 0;
            saveBtn.Enabled = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
