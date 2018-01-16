using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 考勤信息管理
{
   public class SE
    {
       //工号
        private string _No;
        public string No
        {
            get
            {
                return _No;
            }
            set
            {
                _No = value;
            }
        }
       //姓名
       private string _Nameee;
       public string Nameee {
           get {
               return _Nameee;
           }
           set {
               _Nameee = value;
           }
       }
       //年龄
       private string _Age;
       public string Age
       {
           get
           {
               return _Age;
           }
           set
           {
               _Age = value;
           }
       }
       //性别
       private string _Sex;
       public string Sex
       {
           get
           {
               return _Sex;
           }
           set
           {
               _Sex = value;
           }
       }
    }
}
