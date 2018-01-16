using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学员提分
{
    class Program
    {     
        static void Main(string[] args)
        {
            int[] a = new int[3]{ 55, 60, 63 };
            Console.Write("原分数:");
            for (int i = 0; i < a.Length;i++)
            {
                Console.Write("\t"+a[i]);
            }
            int[] aa = new int[3];
            Console.Write("\n"+"现分数:");
            for (int i = 0; i < aa.Length; i++)
            {
                aa[i] = a[i] + 5;
            }
            for (int i = 0; i < aa.Length; i++)
            {
                Console.Write("\t" + aa[i]);
            }
            Console.ReadLine();
        }
    }
}
