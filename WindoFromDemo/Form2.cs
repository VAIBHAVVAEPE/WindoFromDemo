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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtdepName.Clear();
            txtEmpId.Clear();
            txtMobileNo.Clear();
            txtSalary.Clear();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Emp Id = " + txtEmpId.Text + " Emp Dep Name = " + txtdepName.Text + " Mobile Number = " + txtMobileNo.Text + " Emp Salary = " + txtSalary.Text);
            
            
        }

       
    }
}
