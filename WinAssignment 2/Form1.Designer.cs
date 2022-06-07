namespace WinAssignment_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labEnterName = new System.Windows.Forms.Label();
            this.labADD = new System.Windows.Forms.Label();
            this.labDELETE = new System.Windows.Forms.Label();
            this.labCLEAR = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labEnterName
            // 
            this.labEnterName.AutoSize = true;
            this.labEnterName.Location = new System.Drawing.Point(67, 80);
            this.labEnterName.Name = "labEnterName";
            this.labEnterName.Size = new System.Drawing.Size(78, 16);
            this.labEnterName.TabIndex = 0;
            this.labEnterName.Text = "Enter Name";
            // 
            // labADD
            // 
            this.labADD.AutoSize = true;
            this.labADD.Location = new System.Drawing.Point(540, 80);
            this.labADD.Name = "labADD";
            this.labADD.Size = new System.Drawing.Size(36, 16);
            this.labADD.TabIndex = 0;
            this.labADD.Text = "ADD";
            this.labADD.Click += new System.EventHandler(this.labADD_Click);
            // 
            // labDELETE
            // 
            this.labDELETE.AutoSize = true;
            this.labDELETE.Location = new System.Drawing.Point(540, 154);
            this.labDELETE.Name = "labDELETE";
            this.labDELETE.Size = new System.Drawing.Size(60, 16);
            this.labDELETE.TabIndex = 0;
            this.labDELETE.Text = "DELETE";
            this.labDELETE.Click += new System.EventHandler(this.labDELETE_Click);
            // 
            // labCLEAR
            // 
            this.labCLEAR.AutoSize = true;
            this.labCLEAR.Location = new System.Drawing.Point(540, 231);
            this.labCLEAR.Name = "labCLEAR";
            this.labCLEAR.Size = new System.Drawing.Size(51, 16);
            this.labCLEAR.TabIndex = 0;
            this.labCLEAR.Text = "CLEAR";
            this.labCLEAR.Click += new System.EventHandler(this.labCLEAR_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(193, 217);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(8, 8);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(175, 80);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(170, 22);
            this.txtUname.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(183, 200);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 132);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.labCLEAR);
            this.Controls.Add(this.labDELETE);
            this.Controls.Add(this.labADD);
            this.Controls.Add(this.labEnterName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEnterName;
        private System.Windows.Forms.Label labADD;
        private System.Windows.Forms.Label labDELETE;
        private System.Windows.Forms.Label labCLEAR;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.ListBox listBox1;
    }
}

