using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用多态输出形状
{
    class Program
    {
        static void Main(string[] args)
        {
           Shape s = new Circle();
           s.Draw();
           Shape s1 = new Rect();
           s1.Draw();
           Console.ReadLine();
        }
    }
}
