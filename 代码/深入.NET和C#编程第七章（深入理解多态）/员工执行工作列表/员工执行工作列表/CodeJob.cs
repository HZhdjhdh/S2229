using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工执行工作列表
{
   public class CodeJob:Job
    {
        public CodeJob(string type, string name, string description):base( type,name,description)
        { 
       }
        public CodeJob() { }
        //有效编码行数
        public int CodingLines { get; set; }
        //没有解决的Bug
        public int Bugs { get; set; }
        //用时
        public int WorkDay { get; set; }
        public override void Execute()
        {
            FrmTestExe frmTestExe = new FrmTestExe(this);
            frmTestExe.ShowDialog();
        }
        public override void Result()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("测试例案个数:{0}"+"\n"+"发现Bug个数:{1}"+"\n"+"需要工作日{2}",CodingLines.ToString(),Bugs.ToString(),WorkDay.ToString());
            System.Windows.Forms.MessageBox.Show(sb.ToString());

        }
    }
}
