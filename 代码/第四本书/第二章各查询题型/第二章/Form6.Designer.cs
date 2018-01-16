namespace 第二章
{
    partial class Form6
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("女", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("S1", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("女", 1, 1);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("S2", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("女", 1, 1);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Y2", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvShow = new System.Windows.Forms.TreeView();
            this.iltuping = new System.Windows.Forms.ImageList(this.components);
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contkuanjie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.contkuanjie.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvShow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvShow);
            this.splitContainer1.Size = new System.Drawing.Size(895, 455);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvShow
            // 
            this.tvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvShow.ImageIndex = 0;
            this.tvShow.ImageList = this.iltuping;
            this.tvShow.Location = new System.Drawing.Point(0, 0);
            this.tvShow.Name = "tvShow";
            treeNode1.Name = "节点4";
            treeNode1.Text = "男";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "节点5";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "女";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "节点1";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "S1";
            treeNode4.Name = "节点6";
            treeNode4.Text = "男";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "节点7";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "女";
            treeNode6.Name = "节点2";
            treeNode6.Text = "S2";
            treeNode7.Name = "节点8";
            treeNode7.Text = "男";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "节点9";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "女";
            treeNode9.Name = "节点3";
            treeNode9.Text = "Y2";
            treeNode10.Name = "节点0";
            treeNode10.Text = "全部";
            this.tvShow.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.tvShow.SelectedImageIndex = 0;
            this.tvShow.Size = new System.Drawing.Size(297, 455);
            this.tvShow.StateImageList = this.iltuping;
            this.tvShow.TabIndex = 0;
            this.tvShow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShow_AfterSelect);
            // 
            // iltuping
            // 
            this.iltuping.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iltuping.ImageStream")));
            this.iltuping.TransparentColor = System.Drawing.Color.Transparent;
            this.iltuping.Images.SetKeyName(0, "1.jpg");
            this.iltuping.Images.SetKeyName(1, "QQ图片20171111121140.png");
            // 
            // dgvShow
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNo,
            this.StudentName,
            this.GradeName,
            this.Address,
            this.Email,
            this.Sex});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(0, 0);
            this.dgvShow.Name = "dgvShow";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(594, 455);
            this.dgvShow.TabIndex = 0;
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "StudentNo";
            this.StudentNo.HeaderText = "学号";
            this.StudentNo.Name = "StudentNo";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "学生姓名";
            this.StudentName.Name = "StudentName";
            // 
            // GradeName
            // 
            this.GradeName.DataPropertyName = "GradeName";
            this.GradeName.HeaderText = "班级";
            this.GradeName.Name = "GradeName";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "学生地址";
            this.Address.Name = "Address";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "邮箱";
            this.Email.Name = "Email";
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // contkuanjie
            // 
            this.contkuanjie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contkuanjie.Name = "contkuanjie";
            this.contkuanjie.Size = new System.Drawing.Size(153, 48);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 455);
            this.ContextMenuStrip = this.contkuanjie;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息列表";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.contkuanjie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvShow;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.ImageList iltuping;
        private System.Windows.Forms.ContextMenuStrip contkuanjie;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
    }
}