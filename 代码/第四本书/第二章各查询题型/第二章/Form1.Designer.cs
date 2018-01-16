namespace 第二章
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.Student = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiName = new System.Windows.Forms.ToolStripMenuItem();
            this.按年龄查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生列表ＺToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科目列表QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mszhu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.msMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.HotPink;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Student,
            this.msStudent,
            this.mszhu,
            this.tsmiWindow});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.MdiWindowListItem = this.tsmiWindow;
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(605, 25);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // Student
            // 
            this.Student.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(68, 21);
            this.Student.Text = "账户管理";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ToolStripMenuItem.Text = "修改密码(&S)";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // msStudent
            // 
            this.msStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStudent,
            this.tsmiName,
            this.按年龄查询ToolStripMenuItem,
            this.学生列表ＺToolStripMenuItem,
            this.科目列表QToolStripMenuItem});
            this.msStudent.Name = "msStudent";
            this.msStudent.Size = new System.Drawing.Size(92, 21);
            this.msStudent.Text = "学生用户管理";
            // 
            // tsmiStudent
            // 
            this.tsmiStudent.Name = "tsmiStudent";
            this.tsmiStudent.Size = new System.Drawing.Size(166, 22);
            this.tsmiStudent.Text = "新建学生用户(&N)";
            this.tsmiStudent.Click += new System.EventHandler(this.查询学生ToolStripMenuItem_Click);
            // 
            // tsmiName
            // 
            this.tsmiName.Name = "tsmiName";
            this.tsmiName.Size = new System.Drawing.Size(166, 22);
            this.tsmiName.Text = "按姓名查询(&M)";
            this.tsmiName.Click += new System.EventHandler(this.tsmiName_Click);
            // 
            // 按年龄查询ToolStripMenuItem
            // 
            this.按年龄查询ToolStripMenuItem.Name = "按年龄查询ToolStripMenuItem";
            this.按年龄查询ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.按年龄查询ToolStripMenuItem.Text = "按年龄查询(&L)";
            // 
            // 学生列表ＺToolStripMenuItem
            // 
            this.学生列表ＺToolStripMenuItem.Name = "学生列表ＺToolStripMenuItem";
            this.学生列表ＺToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.学生列表ＺToolStripMenuItem.Text = "学生列表(&Z)";
            // 
            // 科目列表QToolStripMenuItem
            // 
            this.科目列表QToolStripMenuItem.Name = "科目列表QToolStripMenuItem";
            this.科目列表QToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.科目列表QToolStripMenuItem.Text = "科目列表(&Q)";
            // 
            // mszhu
            // 
            this.mszhu.Name = "mszhu";
            this.mszhu.Size = new System.Drawing.Size(44, 21);
            this.mszhu.Text = "帮助";
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.Size = new System.Drawing.Size(64, 21);
            this.tsmiWindow.Text = "窗口(&W)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.HotPink;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(605, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton1.Text = "新建学生用户";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(136, 22);
            this.toolStripButton2.Text = "按姓名查询学生信息";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(136, 22);
            this.toolStripButton3.Text = "按年级查询学生信息";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton4.Text = "学生信息列表";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton5.Text = "科目列表";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(605, 448);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理系统";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem Student;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiName;
        private System.Windows.Forms.ToolStripMenuItem mszhu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem 按年龄查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生列表ＺToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科目列表QToolStripMenuItem;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiWindow;
    }
}

