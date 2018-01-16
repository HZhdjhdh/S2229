using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 利用多态实现工资单打印
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSalary a = new JIli();
            a.Rjh();
            PrintSalary a1 = new Salary();
            a1.Rjh();
            Console.ReadLine();
        }
    }
}
