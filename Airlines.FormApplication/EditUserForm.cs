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
    public partial class EditUserForm : Form
    {
        private int Uid;
        private string confidence;
        private UserDto u;

        public EditUserForm(int uid, string _confidence)
        {
            Uid = uid;
            confidence = _confidence;
            InitializeComponent();
        }

        public EditUserForm()
        {
            InitializeComponent();
        }

        private async void EditUserForm_Load(object sender, EventArgs e)
        {
            u = await Program.Instance.UserController.UserById(Uid);
            if (u.Role.Equals("Administrator"))
            {
                adminRbt.Enabled = false;
                userRbt.Enabled = false;
            }
            emailTxb.Text = u.Email;
            firstnameTxb.Text = u.FirstName;
            lastnameTxb.Text = u.LastName;
            if (u.Role == "User")
                userRbt.Checked = true;
            else
                adminRbt.Checked = true;
            List<string> office = await Program.Instance.UserController.ListOffice();
            foreach(string s in office)
            {
                officeCbx.Items.Add(s);
            }
            officeCbx.SelectedIndex = 0;
            officeCbx.SelectedItem = u.Office;
            
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            u.Email = emailTxb.Text;
            u.FirstName = firstnameTxb.Text;
            u.LastName = lastnameTxb.Text;
            u.Office = officeCbx.SelectedItem.ToString();
            if (userRbt.Checked)
                u.Role = "User";
            else
                u.Role = "Administrator";
            bool re = await Program.Instance.UserController.EditUser(u, confidence);
            if (re)
            {
                MessageBox.Show("Success!");
                this.Close();
            }
            else
                MessageBox.Show("Can't edit user");
        }
    }
}
