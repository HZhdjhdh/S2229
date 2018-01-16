using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工执行工作列表
{
   public  class TestJob:Job
    {
       public TestJob(string type, string name, string description):base( type,name,description)
        { 
       }
       public TestJob() { }
       //编写测试用列个数
       public int  CaseNum { get; set; }
       //发现的Bug
       public int FindBugs { get; set; }
       //用时
       public int  WorkDay { get; set; }
        public override void Execute()
        {
            FrmCodeExe frmCodeExe = new FrmCodeExe(this);
            frmCodeExe.ShowDialog();
        }
        public override void Result()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("有效代码行数:{0}" + "\n" + "解决Bug个数:{1}" + "\n" + "需要工作日{2}", CaseNum.ToString(), FindBugs.ToString(), WorkDay.ToString());
            System.Windows.Forms.MessageBox.Show(sb.ToString());
        }
    }
}
