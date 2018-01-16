using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 员工执行工作列表
{
    public partial class FrmTestExe : Form
    {
        //测试对象
        CodeJob job;
        public FrmTestExe(Job job)
        {
            InitializeComponent();
            this.job = job as CodeJob;
        }
        private void FrmTestExe_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isError = false;
            try
            {
                job.CodingLines = Int32.Parse(this.textBox1.Text.ToString());
                job.Bugs = Int32.Parse(this.textBox2.Text.ToString());
                job.WorkDay = Int32.Parse(this.textBox3.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isError = true;
            }
            if (!isError)
            {
                MessageBox.Show("提交成功！", "提示");
                this.Close();
            }
        }
    }
}
