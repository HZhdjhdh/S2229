using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 利用多态实现工资单打印
{
   public class JIli:PrintSalary
    {
       //public JIli(double price, double price1)
       //    : base(price, price1)
       //{
       //}
        public override void Rjh()
        {
            Console.WriteLine("项目经理的工资：5000");
        }
    }
}
