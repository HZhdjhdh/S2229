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
    public partial class FrmJobs : Form
    {
        
        public FrmJobs()
        {
            InitializeComponent();
        }
        SE emp1;
        private void FrmJobs_Load(object sender, EventArgs e)
        {
            Init();  
            UpdateJob();
            this.gbName.Text = emp1.Name;
        }
        public void Init() {
            List<Job> jobList = new List<Job>();
            jobList.Add(new CodeJob("编码","编码","实现购物车模块"));
            jobList.Add(new CodeJob("编码", "编码基类", "完成项目编码基类"));
            jobList.Add(new TestJob("测试", "压力测试", "测试项目已实现模块"));
           emp1 = new SE("1120","王二毛",24,Gender.male,100,jobList);
        }
        public void UpdateJob() {
            this.dataGridView1.DataSource = emp1.WorkList;
        }
        private void 执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            emp1.WorkList[index].Execute();
        }

        private void 完成情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            emp1.WorkList[index].Result();
        }

        private void gbName_Enter(object sender, EventArgs e)
        {

        }  
    }
}
