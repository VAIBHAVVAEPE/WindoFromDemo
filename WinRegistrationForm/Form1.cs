using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAdde.Clear();
            combCity.SelectedIndex = -1;

            combYear.SelectedIndex = -1;
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
        }

        private void btnSummit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Name=="+txtName.Text);
            MessageBox.Show("mobile=="+txtMobile.Text);
            

        }
    }
}
