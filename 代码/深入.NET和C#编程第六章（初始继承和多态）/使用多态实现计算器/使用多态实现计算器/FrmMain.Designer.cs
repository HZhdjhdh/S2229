namespace 使用多态实现计算器
{
    partial class FrmMain
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
            this.gbNumber = new System.Windows.Forms.GroupBox();
            this.bntNumber = new System.Windows.Forms.Button();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblJi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNumber
            // 
            this.gbNumber.Controls.Add(this.bntNumber);
            this.gbNumber.Controls.Add(this.cbo1);
            this.gbNumber.Controls.Add(this.txt2);
            this.gbNumber.Controls.Add(this.txt1);
            this.gbNumber.Location = new System.Drawing.Point(40, 35);
            this.gbNumber.Name = "gbNumber";
            this.gbNumber.Size = new System.Drawing.Size(574, 166);
            this.gbNumber.TabIndex = 0;
            this.gbNumber.TabStop = false;
            this.gbNumber.Text = "计算";
            // 
            // bntNumber
            // 
            this.bntNumber.Location = new System.Drawing.Point(465, 66);
            this.bntNumber.Name = "bntNumber";
            this.bntNumber.Size = new System.Drawing.Size(75, 23);
            this.bntNumber.TabIndex = 2;
            this.bntNumber.Text = "计算";
            this.bntNumber.UseVisualStyleBackColor = true;
            this.bntNumber.Click += new System.EventHandler(this.bntNumber_Click);
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbo1.Location = new System.Drawing.Point(166, 69);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 20);
            this.cbo1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(320, 69);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 0;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(32, 69);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 0;
            // 
            // lblJi
            // 
            this.lblJi.AutoSize = true;
            this.lblJi.Location = new System.Drawing.Point(174, 225);
            this.lblJi.Name = "lblJi";
            this.lblJi.Size = new System.Drawing.Size(65, 12);
            this.lblJi.TabIndex = 1;
            this.lblJi.Text = "计算结果：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblJi);
            this.Controls.Add(this.gbNumber);
            this.Name = "FrmMain";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbNumber.ResumeLayout(false);
            this.gbNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNumber;
        private System.Windows.Forms.Button bntNumber;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblJi;
        private System.Windows.Forms.Label label2;
    }
}

