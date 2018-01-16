namespace 单列播放
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
            this.components = new System.ComponentModel.Container();
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsplay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmPlay = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            this.cmsplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSong
            // 
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.url});
            this.dgvSong.Location = new System.Drawing.Point(12, 12);
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.RowTemplate.Height = 23;
            this.dgvSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSong.Size = new System.Drawing.Size(352, 236);
            this.dgvSong.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "SongID";
            this.id.HeaderText = "序号";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "SongName";
            this.name.HeaderText = "歌名";
            this.name.Name = "name";
            // 
            // url
            // 
            this.url.DataPropertyName = "SongUrl";
            this.url.HeaderText = "路径";
            this.url.Name = "url";
            // 
            // cmsplay
            // 
            this.cmsplay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmPlay});
            this.cmsplay.Name = "cmsplay";
            this.cmsplay.Size = new System.Drawing.Size(101, 26);
            // 
            // tmPlay
            // 
            this.tmPlay.Name = "tmPlay";
            this.tmPlay.Size = new System.Drawing.Size(100, 22);
            this.tmPlay.Text = "播放";
            this.tmPlay.Click += new System.EventHandler(this.tmPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 262);
            this.ContextMenuStrip = this.cmsplay;
            this.Controls.Add(this.dgvSong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            this.cmsplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.ContextMenuStrip cmsplay;
        private System.Windows.Forms.ToolStripMenuItem tmPlay;
    }
}

