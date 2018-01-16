namespace 第二章
{
    partial class Form2
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
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.txtped = new System.Windows.Forms.TextBox();
            this.txtpwd1 = new System.Windows.Forms.TextBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.lblpwd1 = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.grpAddss = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbogread = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdogirl = new System.Windows.Forms.RadioButton();
            this.rdoboy = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblgread = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnbao = new System.Windows.Forms.Button();
            this.btnqing = new System.Windows.Forms.Button();
            this.grpAdd.SuspendLayout();
            this.grpAddss.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.txtped);
            this.grpAdd.Controls.Add(this.txtpwd1);
            this.grpAdd.Controls.Add(this.txtStudent);
            this.grpAdd.Controls.Add(this.lblpwd1);
            this.grpAdd.Controls.Add(this.lblpwd);
            this.grpAdd.Controls.Add(this.lblStudentNo);
            this.grpAdd.Location = new System.Drawing.Point(12, 12);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(411, 156);
            this.grpAdd.TabIndex = 0;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "用户注册信息";
            // 
            // txtped
            // 
            this.txtped.Location = new System.Drawing.Point(127, 68);
            this.txtped.Name = "txtped";
            this.txtped.PasswordChar = '*';
            this.txtped.Size = new System.Drawing.Size(222, 21);
            this.txtped.TabIndex = 5;
            // 
            // txtpwd1
            // 
            this.txtpwd1.Location = new System.Drawing.Point(127, 95);
            this.txtpwd1.Name = "txtpwd1";
            this.txtpwd1.PasswordChar = '*';
            this.txtpwd1.Size = new System.Drawing.Size(222, 21);
            this.txtpwd1.TabIndex = 4;
            // 
            // txtStudent
            // 
            this.txtStudent.Enabled = false;
            this.txtStudent.ForeColor = System.Drawing.Color.Red;
            this.txtStudent.Location = new System.Drawing.Point(127, 34);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(222, 21);
            this.txtStudent.TabIndex = 3;
            // 
            // lblpwd1
            // 
            this.lblpwd1.AutoSize = true;
            this.lblpwd1.Location = new System.Drawing.Point(43, 104);
            this.lblpwd1.Name = "lblpwd1";
            this.lblpwd1.Size = new System.Drawing.Size(77, 12);
            this.lblpwd1.TabIndex = 2;
            this.lblpwd1.Text = "再次输入密码";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Location = new System.Drawing.Point(43, 71);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(29, 12);
            this.lblpwd.TabIndex = 1;
            this.lblpwd.Text = "密码";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStudentNo.Location = new System.Drawing.Point(43, 34);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(29, 12);
            this.lblStudentNo.TabIndex = 0;
            this.lblStudentNo.Text = "学号";
            // 
            // grpAddss
            // 
            this.grpAddss.Controls.Add(this.txtEmail);
            this.grpAddss.Controls.Add(this.dtpDate);
            this.grpAddss.Controls.Add(this.txtAddress);
            this.grpAddss.Controls.Add(this.txtPhone);
            this.grpAddss.Controls.Add(this.cbogread);
            this.grpAddss.Controls.Add(this.panel1);
            this.grpAddss.Controls.Add(this.txtName);
            this.grpAddss.Controls.Add(this.lblEmail);
            this.grpAddss.Controls.Add(this.lblBornDate);
            this.grpAddss.Controls.Add(this.lblAddress);
            this.grpAddss.Controls.Add(this.lblPhone);
            this.grpAddss.Controls.Add(this.lblgread);
            this.grpAddss.Controls.Add(this.lblSex);
            this.grpAddss.Controls.Add(this.lblName);
            this.grpAddss.Location = new System.Drawing.Point(12, 190);
            this.grpAddss.Name = "grpAddss";
            this.grpAddss.Size = new System.Drawing.Size(411, 300);
            this.grpAddss.TabIndex = 1;
            this.grpAddss.TabStop = false;
            this.grpAddss.Text = "用户基本信息";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 271);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 21);
            this.txtEmail.TabIndex = 16;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(127, 234);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(222, 21);
            this.dtpDate.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 197);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(222, 21);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(127, 159);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(222, 21);
            this.txtPhone.TabIndex = 13;
            // 
            // cbogread
            // 
            this.cbogread.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogread.FormattingEnabled = true;
            this.cbogread.Location = new System.Drawing.Point(127, 108);
            this.cbogread.Name = "cbogread";
            this.cbogread.Size = new System.Drawing.Size(222, 20);
            this.cbogread.TabIndex = 12;
            this.cbogread.SelectedIndexChanged += new System.EventHandler(this.cbogread_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdogirl);
            this.panel1.Controls.Add(this.rdoboy);
            this.panel1.Location = new System.Drawing.Point(127, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 45);
            this.panel1.TabIndex = 11;
            // 
            // rdogirl
            // 
            this.rdogirl.AutoSize = true;
            this.rdogirl.Location = new System.Drawing.Point(149, 16);
            this.rdogirl.Name = "rdogirl";
            this.rdogirl.Size = new System.Drawing.Size(35, 16);
            this.rdogirl.TabIndex = 1;
            this.rdogirl.Text = "女";
            this.rdogirl.UseVisualStyleBackColor = true;
            // 
            // rdoboy
            // 
            this.rdoboy.AutoSize = true;
            this.rdoboy.Checked = true;
            this.rdoboy.Location = new System.Drawing.Point(38, 16);
            this.rdoboy.Name = "rdoboy";
            this.rdoboy.Size = new System.Drawing.Size(35, 16);
            this.rdoboy.TabIndex = 0;
            this.rdoboy.TabStop = true;
            this.rdoboy.Text = "男";
            this.rdoboy.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 21);
            this.txtName.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 271);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 12);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Location = new System.Drawing.Point(43, 234);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(53, 12);
            this.lblBornDate.TabIndex = 8;
            this.lblBornDate.Text = "出生日期";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(49, 197);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "地址";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(49, 159);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(29, 12);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "电话";
            // 
            // lblgread
            // 
            this.lblgread.AutoSize = true;
            this.lblgread.Location = new System.Drawing.Point(43, 108);
            this.lblgread.Name = "lblgread";
            this.lblgread.Size = new System.Drawing.Size(29, 12);
            this.lblgread.TabIndex = 5;
            this.lblgread.Text = "年级";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(43, 70);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "性别";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(43, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名";
            // 
            // btnbao
            // 
            this.btnbao.Location = new System.Drawing.Point(216, 496);
            this.btnbao.Name = "btnbao";
            this.btnbao.Size = new System.Drawing.Size(75, 23);
            this.btnbao.TabIndex = 2;
            this.btnbao.Text = "保存";
            this.btnbao.UseVisualStyleBackColor = true;
            this.btnbao.Click += new System.EventHandler(this.btnbao_Click);
            // 
            // btnqing
            // 
            this.btnqing.Location = new System.Drawing.Point(326, 496);
            this.btnqing.Name = "btnqing";
            this.btnqing.Size = new System.Drawing.Size(75, 23);
            this.btnqing.TabIndex = 3;
            this.btnqing.Text = "清空";
            this.btnqing.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 531);
            this.Controls.Add(this.btnqing);
            this.Controls.Add(this.btnbao);
            this.Controls.Add(this.grpAddss);
            this.Controls.Add(this.grpAdd);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑学生信息";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpAddss.ResumeLayout(false);
            this.grpAddss.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label lblpwd1;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.GroupBox grpAddss;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblgread;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnbao;
        private System.Windows.Forms.Button btnqing;
        public System.Windows.Forms.TextBox txtped;
        public System.Windows.Forms.TextBox txtpwd1;
        public System.Windows.Forms.TextBox txtStudent;
        public System.Windows.Forms.RadioButton rdogirl;
        public System.Windows.Forms.RadioButton rdoboy;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.ComboBox cbogread;
    }
}