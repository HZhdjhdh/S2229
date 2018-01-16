using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商场打折
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入价格:");
            int money = int.Parse(Console.ReadLine());
            Show(ref money);
            Console.WriteLine("现价价格:"+ money);
            Console.ReadLine();
        }
       public static void Show(ref int money){
           if (money >= 100)
           {
               money = money - 50;
           }       
       }
    }
}
