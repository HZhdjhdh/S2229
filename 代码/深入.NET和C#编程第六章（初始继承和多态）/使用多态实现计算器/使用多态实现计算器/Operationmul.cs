using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用多态实现计算器
{
    //乘法
    public class Operationmul:Operation
    {
        public override double GetResult()
        {
            double result = NumberA * NumberB;
            return result;
        }
    }
}
