using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现工作汇报
{
    //PM类
   public class PM:Employee
    {
       public int YearOfExperience { get; set; }
       public string DoWork() {
           string message = this.Name + ":管理员完成工作内容！";
           return message;
       }
       //修改PM构造函数
       public PM(string id, string name, int age, Gender gender, int yearOfExperience, List<Job> list)
           : base(id, age, name, gender, list)
       { 
       this.YearOfExperience=yearOfExperience;
       }
    }
}
