using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.net_homeWork_of_Course_Connected_Architecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtFees.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAllInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
