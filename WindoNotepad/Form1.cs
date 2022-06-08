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

namespace WindoNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void coppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void sellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult result = fd.ShowDialog();

            if (DialogResult.OK == result)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog fd1 = new ColorDialog();
            DialogResult result1 = fd1.ShowDialog();
            if (DialogResult.OK == result1)
            {
                richTextBox1.SelectionColor = fd1.Color;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("do u want exit ?", "Warning", MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void saveASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.DefaultExt = ".txt";
            sd.Filter = "Text doc(.txt)|*.txt|Word Doc(.docx)|*.docx|Pdf File(.pdf)|*.pdf";
            DialogResult result = sd.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();

            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text doc(.txt)|*.txt|Word Doc(.docx)|*.docx|Pdf File(.pdf)|*.pdf|All Files|*.*";
            DialogResult result = od.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(od.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();

            }
            
        }
    }
}
