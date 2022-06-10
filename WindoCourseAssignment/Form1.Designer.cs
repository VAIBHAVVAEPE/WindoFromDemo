namespace WindoCourseAssignment
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
            this.labId = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(88, 85);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(64, 16);
            this.labId.TabIndex = 0;
            this.labId.Text = "Course id";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(88, 144);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(90, 16);
            this.labName.TabIndex = 0;
            this.labName.Text = "Course Name";
            this.labName.Click += new System.EventHandler(this.labName_Click);
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(88, 209);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(84, 16);
            this.labFees.TabIndex = 0;
            this.labFees.Text = "Course Fees";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWrite.Location = new System.Drawing.Point(426, 77);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 34);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(426, 160);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(175, 89);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 22);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(175, 206);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(131, 22);
            this.txtFees.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.labFees);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFees;
    }
}

