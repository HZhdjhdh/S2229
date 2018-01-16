using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用多态实现计算器
{
    //实现除法类
   public class OperationDiv:Operation
    {
       public override double GetResult()
       {
          if(NumberB==0){
              throw new Exception("除数不能为零！");
          }
          double result = NumberA / NumberB;
          return result;
       }
    }
}
