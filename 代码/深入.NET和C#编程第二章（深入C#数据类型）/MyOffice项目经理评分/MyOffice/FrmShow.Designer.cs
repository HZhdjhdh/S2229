namespace MyOffice
{
    partial class FrmShow
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
            this.lVAssess = new System.Windows.Forms.ListView();
            this.chnumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chping = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chfen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lVAssess
            // 
            this.lVAssess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chnumber,
            this.chName,
            this.chAge,
            this.chping,
            this.chfen});
            this.lVAssess.FullRowSelect = true;
            this.lVAssess.Location = new System.Drawing.Point(12, 12);
            this.lVAssess.Name = "lVAssess";
            this.lVAssess.Size = new System.Drawing.Size(512, 365);
            this.lVAssess.TabIndex = 0;
            this.lVAssess.UseCompatibleStateImageBehavior = false;
            this.lVAssess.View = System.Windows.Forms.View.Details;
            this.lVAssess.SelectedIndexChanged += new System.EventHandler(this.lVAssess_SelectedIndexChanged);
            this.lVAssess.DoubleClick += new System.EventHandler(this.lVAssess_DoubleClick);
            // 
            // chnumber
            // 
            this.chnumber.Text = "工号";
            this.chnumber.Width = 100;
            // 
            // chAge
            // 
            this.chAge.Text = "年龄";
            this.chAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAge.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "姓名";
            this.chName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chName.Width = 100;
            // 
            // chping
            // 
            this.chping.Text = "评价";
            this.chping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chping.Width = 100;
            // 
            // chfen
            // 
            this.chfen.Text = "年度得分";
            this.chfen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chfen.Width = 100;
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 389);
            this.Controls.Add(this.lVAssess);
            this.Name = "FrmShow";
            this.Text = "查看评分";
            this.Load += new System.EventHandler(this.FrmShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lVAssess;
        private System.Windows.Forms.ColumnHeader chnumber;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chping;
        private System.Windows.Forms.ColumnHeader chfen;
    }
}

