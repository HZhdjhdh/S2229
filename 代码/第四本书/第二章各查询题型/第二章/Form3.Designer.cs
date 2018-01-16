namespace 第二章
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btncha = new System.Windows.Forms.Button();
            this.lblwen = new System.Windows.Forms.Label();
            this.lvQQ = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contshan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contshan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // btncha
            // 
            this.btncha.Location = new System.Drawing.Point(232, 30);
            this.btncha.Name = "btncha";
            this.btncha.Size = new System.Drawing.Size(75, 23);
            this.btncha.TabIndex = 2;
            this.btncha.Text = "查找";
            this.btncha.UseVisualStyleBackColor = true;
            this.btncha.Click += new System.EventHandler(this.btncha_Click);
            // 
            // lblwen
            // 
            this.lblwen.AutoSize = true;
            this.lblwen.Location = new System.Drawing.Point(363, 35);
            this.lblwen.Name = "lblwen";
            this.lblwen.Size = new System.Drawing.Size(89, 12);
            this.lblwen.TabIndex = 3;
            this.lblwen.Text = "(支持模糊查找)";
            // 
            // lvQQ
            // 
            this.lvQQ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvQQ.FullRowSelect = true;
            this.lvQQ.GridLines = true;
            this.lvQQ.Location = new System.Drawing.Point(43, 78);
            this.lvQQ.MultiSelect = false;
            this.lvQQ.Name = "lvQQ";
            this.lvQQ.Size = new System.Drawing.Size(409, 399);
            this.lvQQ.TabIndex = 4;
            this.lvQQ.UseCompatibleStateImageBehavior = false;
            this.lvQQ.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学号";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "年级";
            this.columnHeader4.Width = 90;
            // 
            // contshan
            // 
            this.contshan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.取消ToolStripMenuItem});
            this.contshan.Name = "contshan";
            this.contshan.Size = new System.Drawing.Size(153, 70);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 取消ToolStripMenuItem
            // 
            this.取消ToolStripMenuItem.Name = "取消ToolStripMenuItem";
            this.取消ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.取消ToolStripMenuItem.Text = "修改";
            this.取消ToolStripMenuItem.Click += new System.EventHandler(this.取消ToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 489);
            this.ContextMenuStrip = this.contshan;
            this.Controls.Add(this.lvQQ);
            this.Controls.Add(this.lblwen);
            this.Controls.Add(this.btncha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblName);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "按学生姓名查询";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.contshan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btncha;
        private System.Windows.Forms.Label lblwen;
        private System.Windows.Forms.ListView lvQQ;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contshan;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消ToolStripMenuItem;
    }
}