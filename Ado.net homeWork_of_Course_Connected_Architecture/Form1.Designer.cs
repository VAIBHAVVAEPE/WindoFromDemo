namespace Ado.net_homeWork_of_Course_Connected_Architecture
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
            this.btnClear = new System.Windows.Forms.Button();
            this.labId = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowAllInfo = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(25, 238);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(40, 72);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(64, 16);
            this.labId.TabIndex = 1;
            this.labId.Text = "Course Id";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(34, 128);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(90, 16);
            this.labName.TabIndex = 1;
            this.labName.Text = "Course Name";
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(40, 179);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(84, 16);
            this.labFees.TabIndex = 1;
            this.labFees.Text = "Course Fees";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(290, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(290, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(161, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowAllInfo
            // 
            this.btnShowAllInfo.Location = new System.Drawing.Point(476, 285);
            this.btnShowAllInfo.Name = "btnShowAllInfo";
            this.btnShowAllInfo.Size = new System.Drawing.Size(174, 23);
            this.btnShowAllInfo.TabIndex = 0;
            this.btnShowAllInfo.Text = "Show All Info";
            this.btnShowAllInfo.UseVisualStyleBackColor = true;
            this.btnShowAllInfo.Click += new System.EventHandler(this.btnShowAllInfo_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(141, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 22);
            this.txtID.TabIndex = 2;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(141, 176);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(128, 22);
            this.txtFees.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 208);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(290, 238);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labFees);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAllInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Connected Architecture";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowAllInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

