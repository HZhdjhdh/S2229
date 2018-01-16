using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工执行工作列表
{
    public enum Gender
    {
        male, female
    }
   public class SE
    {
      

            public string No { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public Gender Gender { get; set; }
            public int Number { get; set; }
            public List<Job> WorkList { get; set; }

            public SE(string no, string name, int age, Gender gender, int number, List<Job> workList)
            {
                this.No = no;
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
                this.Number = number;
                this.WorkList = workList;
        }
   
}
    }
