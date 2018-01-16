namespace KTV后台
{
    partial class denglu
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
            this.lblzhang = new System.Windows.Forms.Label();
            this.lblmima = new System.Windows.Forms.Label();
            this.txtzhang = new System.Windows.Forms.TextBox();
            this.txtmima = new System.Windows.Forms.TextBox();
            this.btndeng = new System.Windows.Forms.Button();
            this.btnqu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblzhang
            // 
            this.lblzhang.AutoSize = true;
            this.lblzhang.Location = new System.Drawing.Point(44, 65);
            this.lblzhang.Name = "lblzhang";
            this.lblzhang.Size = new System.Drawing.Size(29, 12);
            this.lblzhang.TabIndex = 0;
            this.lblzhang.Text = "账号";
            // 
            // lblmima
            // 
            this.lblmima.AutoSize = true;
            this.lblmima.Location = new System.Drawing.Point(44, 127);
            this.lblmima.Name = "lblmima";
            this.lblmima.Size = new System.Drawing.Size(29, 12);
            this.lblmima.TabIndex = 0;
            this.lblmima.Text = "密码";
            // 
            // txtzhang
            // 
            this.txtzhang.Location = new System.Drawing.Point(108, 62);
            this.txtzhang.Name = "txtzhang";
            this.txtzhang.Size = new System.Drawing.Size(148, 21);
            this.txtzhang.TabIndex = 1;
            // 
            // txtmima
            // 
            this.txtmima.Location = new System.Drawing.Point(108, 124);
            this.txtmima.Name = "txtmima";
            this.txtmima.PasswordChar = '*';
            this.txtmima.Size = new System.Drawing.Size(148, 21);
            this.txtmima.TabIndex = 1;
            // 
            // btndeng
            // 
            this.btndeng.Location = new System.Drawing.Point(37, 207);
            this.btndeng.Name = "btndeng";
            this.btndeng.Size = new System.Drawing.Size(75, 23);
            this.btndeng.TabIndex = 2;
            this.btndeng.Text = "登录";
            this.btndeng.UseVisualStyleBackColor = true;
            this.btndeng.Click += new System.EventHandler(this.btndeng_Click);
            // 
            // btnqu
            // 
            this.btnqu.Location = new System.Drawing.Point(181, 207);
            this.btnqu.Name = "btnqu";
            this.btnqu.Size = new System.Drawing.Size(75, 23);
            this.btnqu.TabIndex = 2;
            this.btnqu.Text = "取消";
            this.btnqu.UseVisualStyleBackColor = true;
            this.btnqu.Click += new System.EventHandler(this.btnqu_Click);
            // 
            // denglu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTV后台.Properties.Resources._177_10222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 317);
            this.Controls.Add(this.btnqu);
            this.Controls.Add(this.btndeng);
            this.Controls.Add(this.txtmima);
            this.Controls.Add(this.txtzhang);
            this.Controls.Add(this.lblmima);
            this.Controls.Add(this.lblzhang);
            this.Name = "denglu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV登录页面";
            this.Load += new System.EventHandler(this.denglu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblzhang;
        private System.Windows.Forms.Label lblmima;
        private System.Windows.Forms.TextBox txtzhang;
        private System.Windows.Forms.TextBox txtmima;
        private System.Windows.Forms.Button btndeng;
        private System.Windows.Forms.Button btnqu;
    }
}

