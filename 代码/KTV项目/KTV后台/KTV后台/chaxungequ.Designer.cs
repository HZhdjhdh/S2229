namespace KTV后台
{
    partial class chaxungequ
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbllei = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnchaxun = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.song_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songtype_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_piay_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sing_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_ab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.song_id,
            this.song_name,
            this.songtype_name,
            this.song_piay_count,
            this.sing_name,
            this.song_ab,
            this.song_url});
            this.dataGridView1.Location = new System.Drawing.Point(18, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(709, 272);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 21);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "歌曲名";
            // 
            // lbllei
            // 
            this.lbllei.AutoSize = true;
            this.lbllei.Location = new System.Drawing.Point(324, 43);
            this.lbllei.Name = "lbllei";
            this.lbllei.Size = new System.Drawing.Size(53, 12);
            this.lbllei.TabIndex = 8;
            this.lbllei.Text = "歌曲类型";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(440, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 9;
            // 
            // btnchaxun
            // 
            this.btnchaxun.Location = new System.Drawing.Point(609, 38);
            this.btnchaxun.Name = "btnchaxun";
            this.btnchaxun.Size = new System.Drawing.Size(75, 23);
            this.btnchaxun.TabIndex = 10;
            this.btnchaxun.Text = "查询";
            this.btnchaxun.UseVisualStyleBackColor = true;
            this.btnchaxun.Click += new System.EventHandler(this.btnchaxun_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // song_id
            // 
            this.song_id.DataPropertyName = "song_id";
            this.song_id.HeaderText = "ID";
            this.song_id.Name = "song_id";
            this.song_id.Visible = false;
            // 
            // song_name
            // 
            this.song_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.song_name.DataPropertyName = "song_name";
            this.song_name.HeaderText = "歌曲名";
            this.song_name.Name = "song_name";
            this.song_name.ToolTipText = "200";
            this.song_name.Width = 120;
            // 
            // songtype_name
            // 
            this.songtype_name.DataPropertyName = "songtype_name";
            this.songtype_name.HeaderText = "歌曲类别";
            this.songtype_name.Name = "songtype_name";
            this.songtype_name.Width = 120;
            // 
            // song_piay_count
            // 
            this.song_piay_count.DataPropertyName = "song_piay_count";
            this.song_piay_count.HeaderText = "点播次数";
            this.song_piay_count.Name = "song_piay_count";
            this.song_piay_count.Width = 120;
            // 
            // sing_name
            // 
            this.sing_name.DataPropertyName = "sing_name";
            this.sing_name.HeaderText = "歌手姓名";
            this.sing_name.Name = "sing_name";
            // 
            // song_ab
            // 
            this.song_ab.DataPropertyName = "song_ab";
            this.song_ab.HeaderText = "拼音缩写";
            this.song_ab.Name = "song_ab";
            // 
            // song_url
            // 
            this.song_url.DataPropertyName = "song_url";
            this.song_url.HeaderText = "歌曲路径";
            this.song_url.Name = "song_url";
            // 
            // chaxungequ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 388);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnchaxun);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbllei);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "chaxungequ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询歌曲";
            this.Load += new System.EventHandler(this.chaxungequ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbllei;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnchaxun;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn songtype_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_piay_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn sing_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_ab;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_url;
    }
}