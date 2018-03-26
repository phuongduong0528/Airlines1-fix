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
    public partial class NoLogOutForm : Form
    {
        private int uid;
        private string confidence;

        public NoLogOutForm(int _uid, string _confidence)
        {
            InitializeComponent();
            uid = _uid;
            confidence = _confidence;
        }

        public NoLogOutForm()
        {
            InitializeComponent();
        }

        private void NoLogOutForm_Load(object sender, EventArgs e)
        {
            
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(reasonRtb.Text))
            {
                MessageBox.Show("Please specify reason");
                return;
            }
            bool result = await Program.Instance.UserActivityController.NoLogOutLogs(
                uid, reasonRtb.Text, confidence);
            if (result)
                this.Close();
            else
                MessageBox.Show("Can't log in");
        }
    }
}
