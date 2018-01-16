using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 利用多态实现工资单打印
{
   public class Salary:PrintSalary
    {
       //public double Price2 { get; set; }

       public override void Rjh()
       {
           Console.WriteLine("工程师的工资：4000");
       }
    }
}
