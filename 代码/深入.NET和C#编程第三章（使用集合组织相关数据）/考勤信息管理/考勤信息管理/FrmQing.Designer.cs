namespace 考勤信息管理
{
    partial class FrmQing
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "共有1条打卡记录";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namss,
            this.SingInTime,
            this.SingOutTime});
            this.dataGridView2.Location = new System.Drawing.Point(39, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(347, 328);
            this.dataGridView2.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "工号";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Namss
            // 
            this.Namss.HeaderText = "姓名";
            this.Namss.Name = "Namss";
            // 
            // SingInTime
            // 
            this.SingInTime.DataPropertyName = "SingInTime";
            this.SingInTime.HeaderText = "签到时间";
            this.SingInTime.Name = "SingInTime";
            // 
            // SingOutTime
            // 
            this.SingOutTime.DataPropertyName = "SingOutTime";
            this.SingOutTime.HeaderText = "签退时间";
            this.SingOutTime.Name = "SingOutTime";
            // 
            // FrmQing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 418);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQing";
            this.Text = "打卡记录";
            this.Load += new System.EventHandler(this.FrmQing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namss;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingOutTime;
    }
}