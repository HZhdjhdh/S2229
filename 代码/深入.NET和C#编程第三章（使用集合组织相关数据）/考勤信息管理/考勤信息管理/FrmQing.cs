﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 考勤信息管理
{
    public partial class FrmQing : Form
    {
        public FrmQing()
        {
            InitializeComponent();
        }

        private void FrmQing_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = FrmMian.recordList.Values;
            this.dataGridView2.DataSource = bs;
        }
    }
}
