namespace 第一章
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.tetName = new System.Windows.Forms.TextBox();
            this.tetpwd = new System.Windows.Forms.TextBox();
            this.lblyonghu = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.btuniu = new System.Windows.Forms.Button();
            this.btnniun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(26, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "用户名";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblpwd.Location = new System.Drawing.Point(30, 99);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(47, 19);
            this.lblpwd.TabIndex = 1;
            this.lblpwd.Text = "密码";
            // 
            // tetName
            // 
            this.tetName.Location = new System.Drawing.Point(116, 37);
            this.tetName.MaxLength = 100;
            this.tetName.Multiline = true;
            this.tetName.Name = "tetName";
            this.tetName.Size = new System.Drawing.Size(100, 21);
            this.tetName.TabIndex = 2;
            this.tetName.TextChanged += new System.EventHandler(this.tetName_TextChanged);
            // 
            // tetpwd
            // 
            this.tetpwd.Location = new System.Drawing.Point(116, 99);
            this.tetpwd.MaxLength = 100;
            this.tetpwd.Multiline = true;
            this.tetpwd.Name = "tetpwd";
            this.tetpwd.PasswordChar = '*';
            this.tetpwd.Size = new System.Drawing.Size(100, 21);
            this.tetpwd.TabIndex = 3;
            // 
            // lblyonghu
            // 
            this.lblyonghu.AutoSize = true;
            this.lblyonghu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblyonghu.Location = new System.Drawing.Point(26, 159);
            this.lblyonghu.Name = "lblyonghu";
            this.lblyonghu.Size = new System.Drawing.Size(85, 19);
            this.lblyonghu.TabIndex = 4;
            this.lblyonghu.Text = "选择角色";
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Items.AddRange(new object[] {
            "教师",
            "学生",
            "家长"});
            this.cboName.Location = new System.Drawing.Point(116, 159);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(121, 20);
            this.cboName.TabIndex = 5;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
            // 
            // btuniu
            // 
            this.btuniu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btuniu.Location = new System.Drawing.Point(34, 232);
            this.btuniu.Name = "btuniu";
            this.btuniu.Size = new System.Drawing.Size(75, 23);
            this.btuniu.TabIndex = 6;
            this.btuniu.Text = "登录";
            this.btuniu.UseVisualStyleBackColor = true;
            this.btuniu.Click += new System.EventHandler(this.btuniu_Click);
            // 
            // btnniun
            // 
            this.btnniun.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnniun.Location = new System.Drawing.Point(166, 232);
            this.btnniun.Name = "btnniun";
            this.btnniun.Size = new System.Drawing.Size(75, 23);
            this.btnniun.TabIndex = 7;
            this.btnniun.Text = "取消";
            this.btnniun.UseVisualStyleBackColor = true;
            this.btnniun.Click += new System.EventHandler(this.btnniun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.btnniun);
            this.Controls.Add(this.btuniu);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.lblyonghu);
            this.Controls.Add(this.tetpwd);
            this.Controls.Add(this.tetName);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox tetName;
        private System.Windows.Forms.TextBox tetpwd;
        private System.Windows.Forms.Label lblyonghu;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Button btuniu;
        private System.Windows.Forms.Button btnniun;
    }
}

