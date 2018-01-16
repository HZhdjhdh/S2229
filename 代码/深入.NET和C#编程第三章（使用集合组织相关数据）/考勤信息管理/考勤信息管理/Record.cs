using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 考勤信息管理
{
   public class Record
    {
       //签到时间
        public DateTime SingInTime { get; set; }
       //签退时间
        public DateTime SingOutTime { get; set; }
       //工号
        public string  ID { get; set; }
       //员工姓名   
        public string Namss{ get; set; }
    }
}
