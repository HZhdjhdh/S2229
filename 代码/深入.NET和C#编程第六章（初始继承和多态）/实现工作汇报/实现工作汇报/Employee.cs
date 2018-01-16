using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现工作汇报
{
    public enum Gender
    { 
        male,female
    }
    //父类
   public class Employee
    {
        public int  Age { get; set; }
        public Gender Gender { get; set; }
        public string  ID { get; set; }
        public string  Name { get; set; }
        //给 Employee类添加工作列表属性
        protected List<Job> WorkList { get; set; }
        //给 Employee构造函数
        public Employee(string id, int age, string name, Gender gender, List<Job> list)
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.WorkList = list;
        }
    }
}
