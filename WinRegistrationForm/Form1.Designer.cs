namespace WinRegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.labEmail = new System.Windows.Forms.Label();
            this.labMobile = new System.Windows.Forms.Label();
            this.labAdd = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAdde = new System.Windows.Forms.TextBox();
            this.labCity = new System.Windows.Forms.Label();
            this.combYear = new System.Windows.Forms.ComboBox();
            this.combCity = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.btnSummit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Data Form";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labName.Location = new System.Drawing.Point(208, 73);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(115, 22);
            this.labName.TabIndex = 1;
            this.labName.Text = "Enter Name :";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Cyan;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnReset.Location = new System.Drawing.Point(212, 361);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 54);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labEmail.Location = new System.Drawing.Point(208, 111);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(112, 22);
            this.labEmail.TabIndex = 1;
            this.labEmail.Text = "Enter Email :";
            // 
            // labMobile
            // 
            this.labMobile.AutoSize = true;
            this.labMobile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMobile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labMobile.Location = new System.Drawing.Point(208, 147);
            this.labMobile.Name = "labMobile";
            this.labMobile.Size = new System.Drawing.Size(105, 22);
            this.labMobile.TabIndex = 1;
            this.labMobile.Text = "Mobile No. :";
            // 
            // labAdd
            // 
            this.labAdd.AutoSize = true;
            this.labAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labAdd.Location = new System.Drawing.Point(208, 183);
            this.labAdd.Name = "labAdd";
            this.labAdd.Size = new System.Drawing.Size(86, 22);
            this.labAdd.TabIndex = 1;
            this.labAdd.Text = "Addrass :";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labYear.Location = new System.Drawing.Point(208, 216);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(128, 22);
            this.labYear.TabIndex = 1;
            this.labYear.Text = "Passout Year :";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labGender.Location = new System.Drawing.Point(208, 252);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(80, 22);
            this.labGender.TabIndex = 1;
            this.labGender.Text = "Gender :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(362, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(362, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(362, 149);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 22);
            this.txtMobile.TabIndex = 3;
            // 
            // txtAdde
            // 
            this.txtAdde.Location = new System.Drawing.Point(362, 185);
            this.txtAdde.Name = "txtAdde";
            this.txtAdde.Size = new System.Drawing.Size(100, 22);
            this.txtAdde.TabIndex = 3;
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labCity.Location = new System.Drawing.Point(208, 289);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(51, 22);
            this.labCity.TabIndex = 1;
            this.labCity.Text = "City :";
            // 
            // combYear
            // 
            this.combYear.FormattingEnabled = true;
            this.combYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.combYear.Location = new System.Drawing.Point(362, 213);
            this.combYear.Name = "combYear";
            this.combYear.Size = new System.Drawing.Size(121, 24);
            this.combYear.TabIndex = 4;
            // 
            // combCity
            // 
            this.combCity.FormattingEnabled = true;
            this.combCity.Items.AddRange(new object[] {
            "Pune",
            "Sangamner",
            "Mumbai",
            "Nagpur"});
            this.combCity.Location = new System.Drawing.Point(362, 287);
            this.combCity.Name = "combCity";
            this.combCity.Size = new System.Drawing.Size(121, 24);
            this.combCity.TabIndex = 5;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(362, 253);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 6;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(485, 253);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 7;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btnSummit
            // 
            this.btnSummit.BackColor = System.Drawing.Color.Cyan;
            this.btnSummit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummit.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSummit.Location = new System.Drawing.Point(362, 361);
            this.btnSummit.Name = "btnSummit";
            this.btnSummit.Size = new System.Drawing.Size(136, 54);
            this.btnSummit.TabIndex = 2;
            this.btnSummit.Text = "Summit ";
            this.btnSummit.UseVisualStyleBackColor = false;
            this.btnSummit.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.combCity);
            this.Controls.Add(this.combYear);
            this.Controls.Add(this.txtAdde);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSummit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labCity);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labAdd);
            this.Controls.Add(this.labMobile);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registration form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labMobile;
        private System.Windows.Forms.Label labAdd;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAdde;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.ComboBox combYear;
        private System.Windows.Forms.ComboBox combCity;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Button btnSummit;
    }
}

