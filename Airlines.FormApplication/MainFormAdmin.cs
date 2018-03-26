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
    public partial class MainFormAdmin : Form
    {
        private int current_user_id;
        private string confidence;
        List<UserDto> userDtos;
        List<string> office;

        public MainFormAdmin(int _id,string _confidence)
        {
            InitializeComponent();
            current_user_id = _id;
            confidence = _confidence;
        }

        public MainFormAdmin()
        {
            InitializeComponent();
        }

        public async Task LoadCombobox()
        {
            office = await Program.Instance.UserController.ListOffice();
            officeCbx.Items.Clear();
            officeCbx.Items.Add("All");
            foreach (string s in office)
            {
                officeCbx.Items.Add(s);
            }
            officeCbx.SelectedIndex = 0;
        }

        public async Task RefreshData()
        {
            if (officeCbx.SelectedItem.ToString().Equals("All"))
                userDtos = await Program.Instance.UserController.ListUser();
            else
                userDtos = await Program.Instance.UserController
                    .ListUserByOffice(officeCbx.SelectedItem.ToString());
        }

        public void LoadGridView()
        {
            userDgv.DataSource = userDtos;
            for(int i = 0; i < userDgv.RowCount; i++)
            {
                if (userDgv.Rows[i].Cells[8].Value.ToString().Equals("False"))
                {
                    userDgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    userDgv.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                    
            }
            userDgv.Columns[0].Visible = false;
            userDgv.Columns[7].Visible = false;
            userDgv.Columns[8].Visible = false;
            userDgv.Columns[9].Visible = false;
        }

        private async void MainFormAdmin_Load(object sender, EventArgs e)
        {
            userDtos = new List<UserDto>();
            office = new List<string>();
            await LoadCombobox();
            await RefreshData();
            LoadGridView();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Program.Instance.UserActivityController.LogoutLogs(
                current_user_id,
                DateTime.UtcNow.TimeOfDay.ToString(@"hh\:mm\:ss"),
                confidence);
            this.Close();
        }

        private async void officeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                await RefreshData();
                LoadGridView();
            }
            catch(Exception ex)
            {

            }
        }

        private async void disableuserBtn_Click(object sender, EventArgs e)
        {
            int _id;
            try
            {
                int i = userDgv.CurrentCell.RowIndex;
                _id = Convert.ToInt32(userDgv.Rows[i].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("No row selected!");
                return;
            }
            if(_id == current_user_id)
            {
                MessageBox.Show("You can't disable yourself");
                return;
            }
            await Program.Instance.UserController.DisableLogin(_id, confidence);
            await RefreshData();
            LoadGridView();
        }

        private void adduserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm(confidence);
            form.ShowDialog();
        }

        private void changeroleBtn_Click(object sender, EventArgs e)
        {
            int _id;
            try
            {
                int i = userDgv.CurrentCell.RowIndex;
                _id = Convert.ToInt32(userDgv.Rows[i].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("No row selected!");
                return;
            }
            EditUserForm form = new EditUserForm(_id, confidence);
            form.ShowDialog();
            RefreshData();
            LoadGridView();
        }
    }
}
