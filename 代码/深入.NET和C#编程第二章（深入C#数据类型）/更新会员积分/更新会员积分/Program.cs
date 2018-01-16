using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 更新会员积分
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a=new int[5];//历史积分数组
            int[] aa=new int[5];//新年积分数组
            Console.WriteLine("请输入5位会员积分");
            for (int i = 0; i < a.Length;i++ )
            {
                Console.Write("第"+(i+1)+"位会员积分:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //数组复制
            for (int i = 0; i < a.Length;i++ )
            {
                aa[i]=a[i];
                aa[i] = aa[i] + 500;
            }
            Console.WriteLine("\n序号\t历史积分\t新年积分");
            for (int i = 0; i < aa.Length; i++)
            {
                Console.WriteLine((i+1)+"\t"+a[i]+"\t\t"+aa[i]);
            }
            Console.ReadLine();
        }
    }
}
