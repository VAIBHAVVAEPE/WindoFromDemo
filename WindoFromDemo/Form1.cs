using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindoFromDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="Admin"  && txtPassword.Text == "1234")
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }

        
    }
}
