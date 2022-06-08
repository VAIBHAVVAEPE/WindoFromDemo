using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindoFromDemo
{
    public partial class FileInfo1 : Form
    {
        FileStream fs; 
        public FileInfo1()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"D:\SnQBatch1";
            DirectoryInfo di = new DirectoryInfo(path);

            if (di.Exists)
            {
                MessageBox.Show("Folder is already exists");
            }
            else
            {
                di.Create();
                MessageBox.Show("Folder is created");
            }

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\SnQBatch1\Test1.txt";
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                MessageBox.Show("File already exists");
            }
            else
            {
                fi.Create();
                MessageBox.Show("File created");
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\SnQBatch1\Test1.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                int id = Convert.ToInt32(txtDeptId.Text);
                string name = txtName.Text;
                string location = txtLocation.Text;
                bw.Write(id);
                bw.Write(name);
                bw.Write(location);
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
                string loc = br.ReadString();
                txtDeptId.Text = id.ToString();
                txtName.Text = name;
                txtLocation.Text = loc;
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

        
    }

    //private void btnCreateFile_Click(object sender, EventArgs e)
    //{
    //    string path = @"D:\SnQBatch\Test.txt"; // txt-> text file
    //    if (File.Exists(path))
    //    {
    //        MessageBox.Show("File already exists");
    //    }
    //    else
    //    {
    //        File.Create(path);
    //        MessageBox.Show("File created");
    //    }

    //}

    //private void btnCreateFolder_Click(object sender, EventArgs e)
    //{
    //    string path = "D:\\SnQBatch";
    //    if (Directory.Exists(path))
    //    {
    //        MessageBox.Show("Folder is already exists");
    //    }
    //    else
    //    {
    //        Directory.CreateDirectory(path);
    //        MessageBox.Show("Folder is created");
    //    }

    //}
}

