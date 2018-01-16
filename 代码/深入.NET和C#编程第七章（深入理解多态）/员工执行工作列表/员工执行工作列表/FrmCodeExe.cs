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
    public partial class FrmCodeExe : Form
    {
        //编码工作对象
        TestJob job;
        public FrmCodeExe(Job job)
        {
            InitializeComponent();
            this.job = job as TestJob;
        }
  
        //提交编码工作任务
        private void button1_Click(object sender, EventArgs e)
        {
            bool isError = false;
            try
            {
                job.CaseNum = Int32.Parse(this.textBox1.Text.ToString());
                job.FindBugs = Int32.Parse(this.textBox2.Text.ToString());
                job.WorkDay = Int32.Parse(this.textBox3.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isError = true;
            }
            if (!isError)
            {
                MessageBox.Show("提交成功！","提示");
                this.Close();
            }
        }

        private void FrmCodeExe_Load(object sender, EventArgs e)
        {

        }
    }
}
