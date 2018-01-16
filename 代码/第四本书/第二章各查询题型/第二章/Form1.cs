using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第二章
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }


        private void 查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.MdiParent = this;
            a.Show();
        }

        private void tsmiName_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.MdiParent = this;
            a.Show();
        }

      
    }
}
