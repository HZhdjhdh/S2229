namespace 员工执行工作列表
{
    partial class FrmJobs
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
            this.components = new System.ComponentModel.Container();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.执行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完成情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.dataGridView1);
            this.gbName.Location = new System.Drawing.Point(28, 36);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(422, 286);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "王小毛";
            this.gbName.Enter += new System.EventHandler(this.gbName_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Namee,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(19, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(380, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "工作类型";
            this.Type.Name = "Type";
            // 
            // Namee
            // 
            this.Namee.DataPropertyName = "Namee";
            this.Namee.HeaderText = "工作名称";
            this.Namee.Name = "Namee";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "工作描述";
            this.Description.Name = "Description";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.执行ToolStripMenuItem,
            this.完成情况ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 执行ToolStripMenuItem
            // 
            this.执行ToolStripMenuItem.Name = "执行ToolStripMenuItem";
            this.执行ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.执行ToolStripMenuItem.Text = "执行";
            this.执行ToolStripMenuItem.Click += new System.EventHandler(this.执行ToolStripMenuItem_Click);
            // 
            // 完成情况ToolStripMenuItem
            // 
            this.完成情况ToolStripMenuItem.Name = "完成情况ToolStripMenuItem";
            this.完成情况ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.完成情况ToolStripMenuItem.Text = "完成情况";
            this.完成情况ToolStripMenuItem.Click += new System.EventHandler(this.完成情况ToolStripMenuItem_Click);
            // 
            // FrmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 362);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gbName);
            this.Name = "FrmJobs";
            this.Text = "月工作类表";
            this.Load += new System.EventHandler(this.FrmJobs_Load);
            this.gbName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 执行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成情况ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

