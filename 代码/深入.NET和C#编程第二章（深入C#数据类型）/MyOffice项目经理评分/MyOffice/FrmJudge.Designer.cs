﻿namespace MyOffice
{
    partial class FrmJudge
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtping = new System.Windows.Forms.TextBox();
            this.txtfen = new System.Windows.Forms.TextBox();
            this.bntping = new System.Windows.Forms.Button();
            this.bntqu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(78, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(78, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "填写评价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(78, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "年度评分";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 80);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(172, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtping
            // 
            this.txtping.Location = new System.Drawing.Point(171, 193);
            this.txtping.Multiline = true;
            this.txtping.Name = "txtping";
            this.txtping.Size = new System.Drawing.Size(172, 80);
            this.txtping.TabIndex = 1;
            // 
            // txtfen
            // 
            this.txtfen.Location = new System.Drawing.Point(171, 314);
            this.txtfen.Name = "txtfen";
            this.txtfen.Size = new System.Drawing.Size(172, 21);
            this.txtfen.TabIndex = 1;
            // 
            // bntping
            // 
            this.bntping.Location = new System.Drawing.Point(95, 367);
            this.bntping.Name = "bntping";
            this.bntping.Size = new System.Drawing.Size(75, 23);
            this.bntping.TabIndex = 2;
            this.bntping.Text = "评价";
            this.bntping.UseVisualStyleBackColor = true;
            this.bntping.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntqu
            // 
            this.bntqu.Location = new System.Drawing.Point(241, 367);
            this.bntqu.Name = "bntqu";
            this.bntqu.Size = new System.Drawing.Size(75, 23);
            this.bntqu.TabIndex = 2;
            this.bntqu.Text = "取消";
            this.bntqu.UseVisualStyleBackColor = true;
            this.bntqu.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 440);
            this.Controls.Add(this.bntqu);
            this.Controls.Add(this.bntping);
            this.Controls.Add(this.txtfen);
            this.Controls.Add(this.txtping);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmJudge";
            this.Text = "评分";
            this.Load += new System.EventHandler(this.FrmJudge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtping;
        private System.Windows.Forms.TextBox txtfen;
        private System.Windows.Forms.Button bntping;
        private System.Windows.Forms.Button bntqu;
    }
}