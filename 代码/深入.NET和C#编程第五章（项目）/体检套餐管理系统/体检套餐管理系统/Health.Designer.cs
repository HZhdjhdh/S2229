namespace 体检套餐管理系统
{
    partial class Health
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
            this.gbTao = new System.Windows.Forms.GroupBox();
            this.bntName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbption = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nameee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntShan = new System.Windows.Forms.Button();
            this.bntName1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblXiang = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblLI = new System.Windows.Forms.Label();
            this.gbTao.SuspendLayout();
            this.gbption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTao
            // 
            this.gbTao.Controls.Add(this.bntName);
            this.gbTao.Controls.Add(this.txtName);
            this.gbTao.Controls.Add(this.lblName);
            this.gbTao.Location = new System.Drawing.Point(23, 13);
            this.gbTao.Name = "gbTao";
            this.gbTao.Size = new System.Drawing.Size(586, 78);
            this.gbTao.TabIndex = 0;
            this.gbTao.TabStop = false;
            this.gbTao.Text = "新建套餐";
            // 
            // bntName
            // 
            this.bntName.Location = new System.Drawing.Point(278, 33);
            this.bntName.Name = "bntName";
            this.bntName.Size = new System.Drawing.Size(75, 23);
            this.bntName.TabIndex = 2;
            this.bntName.Text = "添加";
            this.bntName.UseVisualStyleBackColor = true;
            this.bntName.Click += new System.EventHandler(this.bntName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "套餐名称";
            // 
            // gbption
            // 
            this.gbption.Controls.Add(this.dataGridView1);
            this.gbption.Controls.Add(this.lblName2);
            this.gbption.Controls.Add(this.label3);
            this.gbption.Controls.Add(this.bntShan);
            this.gbption.Controls.Add(this.bntName1);
            this.gbption.Controls.Add(this.comboBox2);
            this.gbption.Controls.Add(this.comboBox1);
            this.gbption.Controls.Add(this.lblXiang);
            this.gbption.Controls.Add(this.lblPrice);
            this.gbption.Controls.Add(this.lblName1);
            this.gbption.Controls.Add(this.lblLI);
            this.gbption.Location = new System.Drawing.Point(23, 111);
            this.gbption.Name = "gbption";
            this.gbption.Size = new System.Drawing.Size(586, 369);
            this.gbption.TabIndex = 1;
            this.gbption.TabStop = false;
            this.gbption.Text = "检查套餐维护";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nameee,
            this.Description,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(54, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(435, 180);
            this.dataGridView1.TabIndex = 5;
            // 
            // Nameee
            // 
            this.Nameee.DataPropertyName = "Nameee";
            this.Nameee.HeaderText = "项目名";
            this.Nameee.Name = "Nameee";
            this.Nameee.Width = 130;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.Width = 130;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            this.Price.Width = 130;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(133, 155);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(29, 12);
            this.lblName2.TabIndex = 4;
            this.lblName2.Text = "hjyf";
            this.lblName2.Click += new System.EventHandler(this.lblName2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // bntShan
            // 
            this.bntShan.Location = new System.Drawing.Point(402, 107);
            this.bntShan.Name = "bntShan";
            this.bntShan.Size = new System.Drawing.Size(75, 23);
            this.bntShan.TabIndex = 2;
            this.bntShan.Text = "删除";
            this.bntShan.UseVisualStyleBackColor = true;
            this.bntShan.Click += new System.EventHandler(this.bntShan_Click);
            // 
            // bntName1
            // 
            this.bntName1.Location = new System.Drawing.Point(288, 107);
            this.bntName1.Name = "bntName1";
            this.bntName1.Size = new System.Drawing.Size(75, 23);
            this.bntName1.TabIndex = 2;
            this.bntName1.Text = "添加";
            this.bntName1.UseVisualStyleBackColor = true;
            this.bntName1.Click += new System.EventHandler(this.bntName1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(100, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 20);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(345, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // lblXiang
            // 
            this.lblXiang.AutoSize = true;
            this.lblXiang.Location = new System.Drawing.Point(276, 62);
            this.lblXiang.Name = "lblXiang";
            this.lblXiang.Size = new System.Drawing.Size(53, 12);
            this.lblXiang.TabIndex = 0;
            this.lblXiang.Text = "检查项目";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(276, 155);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 12);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "价格：";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(52, 155);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(53, 12);
            this.lblName1.TabIndex = 0;
            this.lblName1.Text = "套餐名：";
            // 
            // lblLI
            // 
            this.lblLI.AutoSize = true;
            this.lblLI.Location = new System.Drawing.Point(40, 59);
            this.lblLI.Name = "lblLI";
            this.lblLI.Size = new System.Drawing.Size(53, 12);
            this.lblLI.TabIndex = 0;
            this.lblLI.Text = "检查列表";
            // 
            // Health
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 492);
            this.Controls.Add(this.gbption);
            this.Controls.Add(this.gbTao);
            this.Name = "Health";
            this.Text = "体检套餐管理系统";
            this.Load += new System.EventHandler(this.Health_Load);
            this.gbTao.ResumeLayout(false);
            this.gbTao.PerformLayout();
            this.gbption.ResumeLayout(false);
            this.gbption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTao;
        private System.Windows.Forms.Button bntName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbption;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntShan;
        private System.Windows.Forms.Button bntName1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblXiang;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblLI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nameee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

