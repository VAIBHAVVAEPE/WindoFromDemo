using System;
using System.IO;
using System.Windows.Forms;

namespace WindoCourseAssignment
{
    public partial class Form1 : Form
    {
        FileStream fs;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {

                fs = new FileStream(@"D:\SnQBatch\Test1.txt", FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                int id = Convert.ToInt32(txtId.Text);
                int fees = Convert.ToInt32(txtFees.Text);
                string name = txtName.Text;
                bw.Write(id);
                bw.Write(name);
                bw.Write(fees);
                bw.Close();
                MessageBox.Show("Done");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\SnQBatch1\Test1.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int id = br.ReadInt32();
                string name = br.ReadString();
                int fees = br.ReadInt32();
                txtId.Text = id.ToString();
                txtName.Text = name;
                txtFees.Text = fees.ToString();
                br.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFees.Clear();
            txtId.Clear();
            txtName.Clear();
        }
    }
}
