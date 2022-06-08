namespace WindoFromDemo
{
    partial class FileInfo1
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.labDeptName = new System.Windows.Forms.Label();
            this.labDeptLocation = new System.Windows.Forms.Label();
            this.labDepId = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(265, 242);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(265, 169);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 13;
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(265, 101);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(100, 22);
            this.txtDeptId.TabIndex = 14;
            // 
            // labDeptName
            // 
            this.labDeptName.AutoSize = true;
            this.labDeptName.Location = new System.Drawing.Point(176, 175);
            this.labDeptName.Name = "labDeptName";
            this.labDeptName.Size = new System.Drawing.Size(76, 16);
            this.labDeptName.TabIndex = 9;
            this.labDeptName.Text = "Dept Name";
            // 
            // labDeptLocation
            // 
            this.labDeptLocation.AutoSize = true;
            this.labDeptLocation.Location = new System.Drawing.Point(176, 242);
            this.labDeptLocation.Name = "labDeptLocation";
            this.labDeptLocation.Size = new System.Drawing.Size(90, 16);
            this.labDeptLocation.TabIndex = 10;
            this.labDeptLocation.Text = "Dept.Location";
            // 
            // labDepId
            // 
            this.labDepId.AutoSize = true;
            this.labDepId.Location = new System.Drawing.Point(176, 110);
            this.labDepId.Name = "labDepId";
            this.labDepId.Size = new System.Drawing.Size(87, 16);
            this.labDepId.TabIndex = 11;
            this.labDepId.Text = "Enter Dept. Id";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(481, 229);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(91, 29);
            this.btnCreateFile.TabIndex = 5;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(481, 110);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(143, 29);
            this.btnCreateFolder.TabIndex = 6;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(441, 321);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(91, 29);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(265, 321);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(91, 29);
            this.btnWrite.TabIndex = 8;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FileInfo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.labDeptName);
            this.Controls.Add(this.labDeptLocation);
            this.Controls.Add(this.labDepId);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.button1);
            this.Name = "FileInfo1";
            this.Text = "FileInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.Label labDeptName;
        private System.Windows.Forms.Label labDeptLocation;
        private System.Windows.Forms.Label labDepId;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button button1;
    }
}