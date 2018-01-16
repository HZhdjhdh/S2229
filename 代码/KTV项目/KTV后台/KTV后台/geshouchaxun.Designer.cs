namespace KTV后台
{
    partial class geshouchaxun
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbllei = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnchaxun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sing_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singtype_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sing_gend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sing_photo_urll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sing_ption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "歌手姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 21);
            this.txtName.TabIndex = 1;
            // 
            // lbllei
            // 
            this.lbllei.AutoSize = true;
            this.lbllei.Location = new System.Drawing.Point(263, 31);
            this.lbllei.Name = "lbllei";
            this.lbllei.Size = new System.Drawing.Size(53, 12);
            this.lbllei.TabIndex = 0;
            this.lbllei.Text = "歌手类型";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // btnchaxun
            // 
            this.btnchaxun.Location = new System.Drawing.Point(502, 26);
            this.btnchaxun.Name = "btnchaxun";
            this.btnchaxun.Size = new System.Drawing.Size(75, 23);
            this.btnchaxun.TabIndex = 3;
            this.btnchaxun.Text = "查询";
            this.btnchaxun.UseVisualStyleBackColor = true;
            this.btnchaxun.Click += new System.EventHandler(this.btnchaxun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sing_name,
            this.singtype_name,
            this.sing_gend,
            this.sing_photo_urll,
            this.sing_ption,
            this.sing_id});
            this.dataGridView1.Location = new System.Drawing.Point(28, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 280);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // sing_name
            // 
            this.sing_name.DataPropertyName = "sing_name";
            this.sing_name.HeaderText = "歌手姓名";
            this.sing_name.Name = "sing_name";
            // 
            // singtype_name
            // 
            this.singtype_name.DataPropertyName = "singtype_name";
            this.singtype_name.HeaderText = "歌手类别";
            this.singtype_name.Name = "singtype_name";
            // 
            // sing_gend
            // 
            this.sing_gend.DataPropertyName = "sing_gend";
            this.sing_gend.HeaderText = "歌手性别";
            this.sing_gend.Name = "sing_gend";
            // 
            // sing_photo_urll
            // 
            this.sing_photo_urll.DataPropertyName = "sing_photo_urll";
            this.sing_photo_urll.HeaderText = "歌曲大小";
            this.sing_photo_urll.Name = "sing_photo_urll";
            // 
            // sing_ption
            // 
            this.sing_ption.DataPropertyName = "sing_ption";
            this.sing_ption.HeaderText = "歌手描述";
            this.sing_ption.Name = "sing_ption";
            // 
            // sing_id
            // 
            this.sing_id.DataPropertyName = "sing_id";
            this.sing_id.HeaderText = "自列";
            this.sing_id.Name = "sing_id";
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
            // geshouchaxun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 402);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnchaxun);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbllei);
            this.Controls.Add(this.lblName);
            this.Name = "geshouchaxun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌手查询";
            this.Load += new System.EventHandler(this.geshouchaxun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbllei;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnchaxun;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sing_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singtype_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sing_gend;
        private System.Windows.Forms.DataGridViewTextBoxColumn sing_photo_urll;
        private System.Windows.Forms.DataGridViewTextBoxColumn sing_ption;
        private System.Windows.Forms.DataGridViewTextBoxColumn sing_id;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}