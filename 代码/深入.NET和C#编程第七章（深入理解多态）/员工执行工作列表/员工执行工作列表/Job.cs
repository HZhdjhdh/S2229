using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工执行工作列表
{
    //工作类  父类
   public abstract class Job
    {
      //工作类型
        public string  Type { get; set; }
       //工作名称
        public string Namee { get; set; }
       //工作描述
        public string  Description{ get; set; }
        public Job(string type, string name, string description)
        {
            this.Type = type;
            this.Namee = name;
            this.Description = description;
        }
        public Job() { }
       //执行
        public abstract void Execute();
       //完成情况
        public abstract void Result();
    }
}
