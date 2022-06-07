using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAssignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labADD_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtUname.Text);
        }

        private void labDELETE_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void labCLEAR_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
